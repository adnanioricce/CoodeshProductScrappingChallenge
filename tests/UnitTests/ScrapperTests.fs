namespace Scrapper

open System.Collections.Generic

module Tests = 

    open System
    open Xunit
    open ProductScrapper.Lib
    open ProductScrapper.Lib.Models
    //TODO:

    [<Fact>]
    let ``scrapper receives the url and scrap all products of the page`` () = async {
        let url = "https://world.openfoodfacts.org/"
        let mockGetString = fun (url:string) -> task { return Tests.Data.allProductsDivStr }
        let scrapper = ProductScrapperService()
        let! products = scrapper.ScrapProductListAsync(mockGetString,url) |> Async.AwaitTask
        Assert.NotEmpty(products)
    }
    //Note: the products scrapped from the initial page have the link to the description page
    [<Fact>]
    let ``complete product must be retrieved from individual description page for each product`` () = async {
        let url = "https://world.openfoodfacts.org/product/3017620422003/nutella-ferrero"
        let mockGetString = fun (url:string) -> task { return Tests.Data.nutellaDescriptionPage }
        let scrapper = ProductScrapperService()        
        let! product = scrapper.ScrapProductDescription(mockGetString,url,Product()) |> Async.AwaitTask        
        Assert.NotEqual(0L,product.Code)
        Assert.NotEqual(ProductStatus.Draft,product.Status)
    }
    [<Fact>]
    let ``get the page numbers to be scrapped based on the biggest page number to be scrapped`` () = async {
        let url = "https://world.openfoodfacts.org"
        let mockGetString = fun (url:string) -> task { return Tests.Data.productPages }
        let scrapper = ProductScrapperService()
        let! lastPageNumber = scrapper.ScrapLastProductPage(mockGetString,url) |> Async.AwaitTask        
        Assert.Equal(27333L,lastPageNumber)
    }