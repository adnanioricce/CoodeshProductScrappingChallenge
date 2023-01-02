namespace Repository

module Tests = 

    open System
    open Xunit
    open ProductScrapper
    open Microsoft.Data.SqlClient
    open System.Data
    [<Theory>]
    [<InlineData(0,50)>]
    let ``test product read`` (page,pageCount) = task {
        let createConn () =
            let conn:IDbConnection = new SqlConnection("Server=localhost,1741;Database=ProductScrapper;User Id=SA;Password=!P4ssword;TrustServerCertificate=True")
            conn
        let repository = SqlProductRepository(CreateConnection(createConn))
        let! products = repository.ListAsync(page,pageCount)
        Assert.NotEmpty(products)
        Assert.Equal(50,products |> Seq.length)
    }
    [<Fact>]
    let ``test product creation`` () = task {
        let createConn () =
            let conn:IDbConnection = new SqlConnection("Server=localhost,1741;Database=ProductScrapper;User Id=SA;Password=!P4ssword;TrustServerCertificate=True")
            conn
        let product = ProductDto(
                    Id = 1,
                    Code = 3661112502850L,
                    Barcode = "3661112502850(EAN / EAN-13)",
                    Status = ProductStatus.Imported,
                    //ImportedAt = DateTimeOffset.Parse("2020-02-07T16:00:00Z"),
                    ImportedAt = "2020-02-07T16:00:00Z",
                    Url = "https://world.openfoodfacts.org/product/3661112502850",
                    ProductName = "Jambon de Paris cuit à l'étouffée",
                    Quantity = "240 g",
                    Categories = "Meats, Prepared meats, Hams, White hams",
                    Packaging = "Film en plastique, Film en plastique",
                    Brands = "Tradilège, Marque Repère",
                    ImageUrl = "https://static.openfoodfacts.org/images/products/366/111/250/2850/front_fr.3.400.jpg")
        let repository = SqlProductRepository(CreateConnection(createConn))
        try
            do! repository.Create(product)
            let! productSaved = repository.GetByCodeAsync(product.Code)
            Assert.Equal(product.Code,productSaved.Code)
        with
            | ex -> Assert.Fail($"Exception when trying to save product:{ex.ToString()}")
    }
