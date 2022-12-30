namespace Api

open System.Collections.Generic

module Tests = 

    open System
    open Xunit
    open ProductScrapper
    open Microsoft.AspNetCore.Http
    open Microsoft.AspNetCore.Http.HttpResults
    //Parser tests
    //TODO: Unit tests for NoContent,Server Error
    [<Fact>]
    let ``GET list product returns ok if not empty`` () = async {    
        let repository:IProductRepository = FakeProductRepository()
        let! products = repository.ListAsync() |> Async.AwaitTask
        let listProductsAsync = repository.ListAsync
        let func () = ProductEndpoints.ListAsync listProductsAsync
        let! r = (func () |> Async.AwaitTask)
        let result = r :?> HttpResults.Ok<IEnumerable<ProductDto>>
        let expectedResult = Results.Ok(products) :?> HttpResults.Ok<Object>                
        let receivedProducts = result.Value
        Assert.Equal(expectedResult.StatusCode,result.StatusCode)
        Assert.Equal<IEnumerable<ProductDto>>(products,receivedProducts)
    }
    [<Fact>]
    let ``GET list product returns no content empty`` () = async {            
        let listProductsFunc = 
            fun _ -> 
                task{ 
                    let products:IEnumerable<ProductDto> = []
                    return products
                } 
        let listProductsAsync:ListProductsAsync = listProductsFunc 
        let func () = ProductEndpoints.ListAsync listProductsAsync
        let! r = (func () |> Async.AwaitTask)    
        let result = r :?> HttpResults.NoContent
        let expectedResult = Results.NoContent() :?> HttpResults.NoContent
        let isEqual = r = expectedResult        
        Assert.Equal(expectedResult.StatusCode,result.StatusCode);
    }
    [<Fact>]
    let ``GET list product returns server error if a unexpected error ocurred`` () = async {            
        let listProductsFunc = 
            fun _ -> 
                task{ 
                    let products:IEnumerable<ProductDto> = []
                    Exception("Unexpected error") |> raise
                    return products
                }
        let listProductsAsync:ListProductsAsync = listProductsFunc
        let func () = ProductEndpoints.ListAsync listProductsAsync
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
        let result = r :?> HttpResults.Ok<ProductDto>
        let expectedResult = Results.Ok<ProductDto>(product) :?> HttpResults.Ok<ProductDto>        
        Assert.Equal(expectedResult.StatusCode,result.StatusCode)
    }
    
