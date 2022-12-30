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
            |> (fun builder -> builder.ExecuteAsync())
        return result
    }
let startApi () = task {
    let! result = dockerCli ["run";"--name productscrapper-api";"-p";"5000:80";"-e";$""" DATABASE_URL="{databaseUrl}" """;"productscrapper/api"]
    return 0
}
let startScrapper () = task {
    let! deleteResult = task {
        let start = DateTimeOffset.UtcNow
        try 
            let! r = dockerCli ["rm";"productscrapper-scrapper"]
            return r
        with
        | ex -> return CommandResult(0,start,DateTimeOffset.UtcNow)
    }
    let! creationResult = dockerCli ["run";"--name productscrapper-scrapper";"-p";"5000:80";"-e";$""" DATABASE_URL="{databaseUrl}" """;"productscrapper/scrapper"]
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