﻿namespace Parser
module Tests = 
    open System
    open Xunit
    open ProductScrapper
    
    let allProductsDivStr = Tests.Data.allProductsDivStr
    let singleProductStr = Tests.Data.singleProductStr
    let nutellaDescriptionPage = Tests.Data.nutellaDescriptionPage
    let parser = ProductParser()
    //Parser tests
    [<Fact>]
    let ``Parse product list page`` () = async {
    
        let! products = parser.ParseProductsFromPage(allProductsDivStr) |> Async.AwaitTask
        let inspector = 
            fun (product:ProductDto) ->
                Assert.Null(product.Barcode)
                Assert.Null(product.Brands)
                Assert.Null(product.Categories)
                Assert.Null(product.Quantity)
                Assert.Null(product.Packaging)
                Assert.Equal(0L,product.Id)            
                Assert.Equal(ProductStatus.Draft,product.Status)
                Assert.NotEmpty(product.Url)
                Assert.NotEmpty(product.ProductName)
                Assert.NotEmpty(product.ImageUrl)
        let inspectors:Action<ProductDto> array = products |> Seq.map (fun p -> (Action<ProductDto> inspector)) |> Seq.toArray            
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