namespace Api

open System.Net.Http



module Tests =
    open System
    open Xunit
    open ProductScrapper
    open Microsoft.Data.SqlClient
    open System.Data
    open System.Text.Json.Serialization
    let client = HttpClient()
    [<Theory>]
    [<InlineData("http://localhost:5073/products")>]
    [<InlineData("http://localhost:5073/products?page=0&pageCount=100")>]
    let ``GET Product list`` (url:string) = task {        
        let! content = client.GetStringAsync(url);
        let products = System.Text.Json.JsonSerializer.Deserialize<ProductDto[]>(content)
        Assert.NotEmpty(products);
    }
    [<Fact>]
    let ``GET Product by code `` () = task {
        let! content = client.GetStringAsync("http://localhost:5073/products/3661112502850");
        let products = System.Text.Json.JsonSerializer.Deserialize<ProductDto[]>(content)
        Assert.NotEmpty(products);
    }    
    [<Fact>]
    let ``GET project description by endpoint`` () = task {        
        let url = "http://localhost:5073"
        let! message = client.GetStringAsync(url)
        Assert.Equal("Fullstack Challenge 20201026",message)
    }
