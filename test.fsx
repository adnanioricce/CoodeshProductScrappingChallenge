#r "nuget: Docker.DotNet"
#r "nuget: CliWrap"
#r "nuget: Microsoft.Data.SqlClient"
module WithDockerDotnet = 
    open Docker.DotNet
    open Docker.DotNet.Models
    let createDockerCli () =    
         let config = new DockerClientConfiguration()
         config.CreateClient()

    let startApi (client:DockerClient) () = task {
        let args = CreateContainerParameters()        
        args.Image <- "productscrapper/api"
        //args.HostConfig.port
        args.HostConfig.PublishAllPorts <- true
        let! r = client.Containers.CreateContainerAsync(args)
        let image = ""
        return ()
    }

open CliWrap
open System
open Microsoft.Data.SqlClient
//let databaseUrl = "jdbc:sqlserver://localhost:1741/ProductScrapper;user=SA;password=!P4ssword"
let databaseUrl = "Server=localhost,1741;Database=ProductScrapper;User Id=SA;Password=!P4ssword;TrustServerCertificate=True"
let dockerCli (args:string seq) = task {
        let! result = 
            Cli.Wrap("docker")
            |> (fun builder -> builder.WithArguments(args))
            |> (fun builder -> builder.WithWorkingDirectory("."))
            |> (fun builder -> builder.WithStandardOutputPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
            |> (fun builder -> builder.WithStandardErrorPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
            |> (fun builder -> builder.ExecuteAsync())
        return result
    }
let dockerComposeCli (args:string seq) = async {
    let! result = 
            Cli.Wrap("docker-compose")
            |> (fun builder -> builder.WithArguments(args))
            |> (fun builder -> builder.WithWorkingDirectory("."))
            |> (fun builder -> builder.WithStandardOutputPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
            |> (fun builder -> builder.WithStandardErrorPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
            |> (fun builder -> builder.ExecuteAsync())
            |> (fun cmd -> cmd.Task |> Async.AwaitTask)
    return result    
}
let dotnetCli (args:string seq) = async {
    let! result =
        Cli.Wrap("dotnet")
        |> (fun builder -> builder.WithArguments(args))
        |> (fun builder -> builder.WithWorkingDirectory("."))
        |> (fun builder -> builder.WithStandardOutputPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
        |> (fun builder -> builder.WithStandardErrorPipe(PipeTarget.ToDelegate(fun src -> printfn "%s" src)))
        |> (fun builder -> builder.ExecuteAsync())        
        |> (fun cmd -> cmd.Task |> Async.AwaitTask)
    return result
}
let startDb () = async {
    let! result = (dockerCli ["run";"--name productscrapper-db";"-p";"1741:1433";"-e";"adnanioricce/productscrapper/db"]) |> Async.AwaitTask
    return 0
}
let startApi () = async {
    let! result = 
        (dockerCli ["run";"--name productscrapper-api";"-p";"5073:80";"-e";$""" DATABASE_URL="{databaseUrl}" """;"adnanioricce/productscrapper/api"])
        |> Async.AwaitTask        
    return 0
}
let startScrapper () = async {
    let! deleteResult = async {
        let start = DateTimeOffset.UtcNow
        try 
            let! r = 
                dockerCli ["rm";"productscrapper-scrapper"]
                |> Async.AwaitTask
            return r
        with
        | ex -> return CommandResult(0,start,DateTimeOffset.UtcNow)
    }
    let! creationResult = 
        dockerCli ["run";"--name productscrapper-scrapper";"-e";$""" DATABASE_URL="{databaseUrl}" """;"adnanioricce/productscrapper/scrapper"]
        |> Async.AwaitTask
    return 0
}

let createConnection () =
        
    let conn = new SqlConnection(databaseUrl)
    conn
let read () =
    let conn = createConnection()
    let cmd = conn.CreateCommand()
    cmd.CommandText <- "SELECT COUNT(*) FROM [dbo].[Products]"
    conn.Open()
    let count = cmd.ExecuteScalar()
    conn.Close()
    conn.Dispose()
    count
let startContainers () = 
    //Start containers
    startDb () |> Async.RunSynchronously |> ignore
    [
    startApi ()
    startScrapper ()
    ] 
    |> Async.Parallel
    |> ignore

let start () = 
    [
    dockerComposeCli ["build"]
    dockerComposeCli ["up";"-d"]    
    ] 
    |> Async.Sequential
    |> Async.Ignore
    |> Async.RunSynchronously
let test () =
    try        
        dotnetCli ["test";"tests/IntegrationTests/"]
        |> Async.Ignore
        |> Async.RunSynchronously    
    with
    | ex -> printfn "%A" ex
let unitTests () =
    try        
        dotnetCli ["test";"tests/UnitTests/"]
        |> Async.Ignore
        |> Async.RunSynchronously    
    with
    | ex -> printfn "%A" ex
let push () =
    try        
        dockerComposeCli ["push"]
        |> Async.Ignore
        |> Async.RunSynchronously    
    with
    | ex -> printfn "%A" ex
let stop () = 
    [
    dockerComposeCli ["stop"]
    dockerComposeCli ["rm";"-fsv"]
    ]
    |> Async.Sequential
    |> Async.Ignore
    |> Async.RunSynchronously

unitTests ()
start ()
test ()
push ()
stop ()
