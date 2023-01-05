CREATE DATABASE ProductScrapper;
GO
USE ProductScrapper;

CREATE TABLE [dbo].[Products](
  --Some products can have the same Code/Barcode
  --Example: https://world.openfoodfacts.org//product/20005733/walnusse-alesto
  Id INT IDENTITY(1,1) NOT NULL
  ,Code         BIGINT NOT NULL
  ,Barcode      VARCHAR(MAX) NOT NULL
  ,Status       INT NOT NULL
  ,ImportedAt   DateTimeOffset(7)
  ,Url          VARCHAR(MAX) NOT NULL
  ,ProductName VARCHAR(MAX) NOT NULL
  ,Quantity     VARCHAR(MAX) NOT NULL
  ,Categories   VARCHAR(MAX) NOT NULL
  ,Packaging    VARCHAR(MAX) NOT NULL
  ,Brands       VARCHAR(MAX) NOT NULL
  ,ImageUrl    VARCHAR(MAX) NOT NULL
);
GO
INSERT INTO [dbo].[Products](Code,Barcode,Status,ImportedAt,Url,ProductName,Quantity,Categories,Packaging,Brands,ImageUrl) 
VALUES (3661112502850
    ,'3661112502850(EAN / EAN-13)'
    ,'imported'
    ,'2020-02-07T16:00:00Z'
    ,'https://world.openfoodfacts.org/product/3661112502850'
    ,'Jambon de Paris cuit à l''étouffée'
    ,'240 g'
    ,'Meats, Prepared meats, Hams, White hams'
    ,'Film en plastique, Film en plastique'
    ,'Tradilège, Marque Repère'
  
  ,'https://static.openfoodfacts.org/images/products/366/111/250/2850/front_fr.3.400.jpg');
GO

CREATE TABLE [dbo].[ProductDrafts](
    Id INT IDENTITY(1,1) NOT NULL
    ,Url VARCHAR(MAX) NOT NULL
    ,Status INT NOT NULL
    ,ScrappedAt VARCHAR(MAX)
)