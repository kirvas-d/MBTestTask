-- Запрос

Select Products.ProductName, Categories.CategoryName
from Products
left join ProductCategory on Products.Id = ProductCategory.ProductId
left join Categories on Categories.Id = ProductCategory.CategoryId


--Схема Базы данных

CREATE TABLE "Categories" (
	"Id"	INTEGER,
	"CategoryName"	TEXT,
	PRIMARY KEY("Id")
);

CREATE TABLE "Products" (
	"Id"	INTEGER,
	"ProductName"	TEXT,
	PRIMARY KEY("Id")
);

CREATE TABLE "ProductCategory" (
	"ProductId"	INTEGER NOT NULL,
	"CategoryId"	INTEGER NOT NULL,
	FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id"),
	FOREIGN KEY("ProductId") REFERENCES "Products"("Id")
);