using AngleSharp.Dom;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using ProductScrapper.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntegrationTests.CSharp
{
    using System;
    using Xunit;
    using Microsoft.Data.SqlClient;
    using System.Data;
    using System.Text.Json.Serialization;
    using ProductScrapper.Lib.Models;
    public class ApiTests
    {
        [Theory]
        [InlineData("http://localhost:5073/products")]
        [InlineData("http://localhost:5073/products?page=0&pageCount=100")]
        //let ``GET Product list`` (url:string) = task {        
        public async Task Get_product_list(string url)
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            var products = System.Text.Json.JsonSerializer.Deserialize<Product[]>(content);
            Assert.NotEmpty(content);
        }
        [Fact]
        //let ``GET Product by code `` () = task {
        public async Task GET_product_by_code()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("http://localhost:5073/products/3661112502850");
            var products = System.Text.Json.JsonSerializer.Deserialize<Product[]>(content);
            Assert.NotEmpty(content);
        }
        [Fact]
        //let ``GET project description by endpoint`` () = task {
        public async Task GET_project_description_by_endpoint()
        {
            using var client = new HttpClient();
            var url = "http://localhost:5073";
            var message = await client.GetStringAsync(url);
            Assert.Equal("Fullstack Challenge 20201026", message);
        }
    }
}
