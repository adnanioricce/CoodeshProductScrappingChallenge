namespace Api

module Tests = 
    
    open System
    open Xunit
    open ProductScrapper
    open Microsoft.AspNetCore.Http
    open Microsoft.AspNetCore.Http.HttpResults
    open System.Collections.Generic
    open ProductScrapper.Lib.Models
    open ProductScrapper.Lib.Repository
    //Parser tests
    //TODO: Unit tests for NoContent,Server Error
    [<Fact>]
    let ``GET list product returns ok if not empty`` () = async {    
        let repository:IProductRepository = FakeProductRepository()
        let! products = repository.ListAsync() |> Async.AwaitTask
        let listProductsAsync page pageCount = repository.ListAsync(page,pageCount)
        let func () = ProductEndpoints.ListAsync(listProductsAsync,0,10)
        let! r = (func () |> Async.AwaitTask)
        let result = r :?> HttpResults.Ok<IEnumerable<Product>>
        let expectedResult = Results.Ok(products) :?> HttpResults.Ok<Object>                
        let receivedProducts = result.Value
        Assert.Equal(expectedResult.StatusCode,result.StatusCode)
        Assert.Equal<IEnumerable<Product>>(products,receivedProducts)
    }
    [<Fact>]
    let ``GET list product returns no content empty`` () = async {            
        let listProductsFunc = 
            fun page pageCount -> 
                task{ 
                    let products:IEnumerable<Product> = []
                    return products
                } 
        let listProductsAsync:ListProductsAsync = listProductsFunc 
        let func () = ProductEndpoints.ListAsync(listProductsAsync,0,10)
        let! r = (func () |> Async.AwaitTask)    
        let result = r :?> HttpResults.NoContent
        let expectedResult = Results.NoContent() :?> HttpResults.NoContent
        let isEqual = r = expectedResult        
        Assert.Equal(expectedResult.StatusCode,result.StatusCode);
    }
    [<Fact>]
    let ``GET list product returns server error if a unexpected error ocurred`` () = async {            
        let listProductsFunc = 
            fun page pageCount -> 
                task{ 
                    let products:IEnumerable<Product> = []
                    Exception("Unexpected error") |> raise
                    return products
                }
        let listProductsAsync:ListProductsAsync = listProductsFunc
        let func () = ProductEndpoints.ListAsync(listProductsAsync,0,10)
        let! r = (func () |> Async.AwaitTask)
        let result = r :?> HttpResults.StatusCodeHttpResult
        let expectedResult = Results.StatusCode(500) :?> HttpResults.StatusCodeHttpResult        
        Assert.Equal(expectedResult.StatusCode,result.StatusCode)
    }    
    //TODO: Unit tests for the products/:code
    [<Fact>]
    let ``GET product by code expect to return a product if id exists`` () = async {
        let repository:IProductRepository = FakeProductRepository()
        let! products = repository.ListAsync() |> Async.AwaitTask
        let product = products |> Seq.head
        let mockGetProductByCode = 
            fun (code:int64)-> 
                task{                     
                    return product
                }        
        //let mockFunc = GetByCodeAsync(mockGetProductByCode)
        let funcUnderTest code = ProductEndpoints.GetByCodeAsync(mockGetProductByCode,code)
        let! r = (funcUnderTest 1 |> Async.AwaitTask)
        let result = r :?> HttpResults.Ok<Product>
        let expectedResult = Results.Ok<Product>(product) :?> HttpResults.Ok<Product>        
        Assert.Equal(expectedResult.StatusCode,result.StatusCode)
    }
    
