namespace Parser
open ProductScrapper.Lib
open ProductScrapper.Lib.Models
module Tests = 
    open System
    open Xunit    
    let allProductsDivStr = Tests.Data.allProductsDivStr
    let singleProductStr = Tests.Data.singleProductStr
    let nutellaDescriptionPage = Tests.Data.nutellaDescriptionPage
    let parser = ProductParser()
    //Parser tests
    [<Fact>]
    let ``Parse product list page`` () = async {
    
        let! products = parser.ParseProductsFromPage(allProductsDivStr) |> Async.AwaitTask
        let inspector = 
            fun (product:Product) ->
                Assert.Null(product.Barcode)
                Assert.Null(product.Brands)
                Assert.Null(product.Categories)
                Assert.Null(product.Quantity)
                Assert.Null(product.Packaging)   
                Assert.Null(product.ProductName)
                Assert.Equal(0L,product.Id)            
                Assert.Equal(ProductStatus.Draft,product.Status)
                Assert.NotEmpty(product.Url)                
                Assert.NotEmpty(product.ImageUrl)
                
        let inspectors:Action<Product> array = products |> Seq.map (fun p -> (Action<Product> inspector)) |> Seq.toArray            
        Assert.NotEmpty(products)
        Assert.Collection(products,inspectors)
    }
    [<Fact>]
    let ``Parse product description page`` () = async {    
        let! products = parser.ParseProductsFromPage(allProductsDivStr) |> Async.AwaitTask
        let sample = products |> Seq.head
        let! desc = parser.ParseProductDescriptionPage(nutellaDescriptionPage,sample) |> Async.AwaitTask
        Assert.NotEmpty(desc.Barcode)
        Assert.NotEmpty(desc.Brands)
        Assert.NotEmpty(desc.Categories)
        Assert.NotEmpty(desc.Quantity)
        Assert.NotEmpty(desc.Packaging)
    }
