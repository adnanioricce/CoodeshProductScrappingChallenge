CREATE TABLE [dbo].[Products](
  Id INT IDENTITY(1,1) NOT NULL
  ,Code         BIGINT NOT NULL
  ,Barcode      VARCHAR(27) NOT NULL
  ,Status       VARCHAR(8) NOT NULL
  ,ImportedAt   VARCHAR(20) NOT NULL
  ,Url          VARCHAR(53) NOT NULL
  ,ProductName VARCHAR(33) NOT NULL
  ,Quantity     VARCHAR(5) NOT NULL
  ,Categories   VARCHAR(39) NOT NULL
  ,Packaging    VARCHAR(36) NOT NULL
  ,Brands       VARCHAR(24) NOT NULL
  ,ImageUrl    VARCHAR(84) NOT NULL
);
INSERT INTO [Products](Code,Barcode,Status,ImportedAt,Url,ProductName,Quantity,Categories,Packaging,Brands,ImageUrl) 
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