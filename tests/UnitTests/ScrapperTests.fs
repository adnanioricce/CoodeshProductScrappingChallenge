namespace Scrapper

open System.Collections.Generic

module Tests = 

    open System
    open Xunit
    open ProductScrapper
    //TODO:

    [<Fact>]
    let ``scrapper receives the url and scrap all products of the page`` () = async {
        let url = "https://world.openfoodfacts.org/"
        let mockGetString = fun (url:string) -> task { return Tests.Data.allProductsDivStr }
        let scrapper = ProductScrapper()
        let! products = scrapper.ScrapProductListAsync(mockGetString,url) |> Async.AwaitTask
        Assert.NotEmpty(products)
    }
    //Note: the products scrapped from the initial page have the link to the description page
    [<Fact>]
    let ``complete product must be retrieved from individual description page for each product`` () = async {
        let url = "https://world.openfoodfacts.org/product/3017620422003/nutella-ferrero"
        let mockGetString = fun (url:string) -> task { return Tests.Data.singleProductStr }
        let scrapper = ProductScrapper()        
        let! product = scrapper.ScrapProductDescription(mockGetString,url,ProductDto()) |> Async.AwaitTask        
        Assert.NotEqual(0L,product.Code)
        Assert.NotEqual(ProductStatus.Draft,product.Status)
    }