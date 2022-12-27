namespace Api
module Tests = 

    open System
    open Xunit
    open ProductScrapper
    open Microsoft.AspNetCore.Http
    //Parser tests
    //TODO: Unit tests for NoContent,Server Error
    [<Fact>]
    let ``GET list product returns ok if not empty`` () = async {    
        let repository:IProductRepository = FakeProductRepository()
        let! products = repository.ListAsync() |> Async.AwaitTask
        let func () = ProductEndpoints.ListAsync repository
        let! r = func () |> Async.AwaitTask
        let expectedResult = Results.Ok(products)
        Assert.Equal(expectedResult,r)
    }
    //TODO: Unit tests for the products/:code
    
