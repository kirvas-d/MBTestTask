# MBTestTask

## Задание №1

Написать библиотеку для вычисления площади круга по радиусу и треугольника по трем сторонам.

```MBTestTask/MindBoxTestTask/Interfaces``` - содержит интерфейс ICalculateFigureArea с методом GetArea() для подсчета площади фигуры.

Для того чтобы добавить новую фигуру необходимо создать класс фигуры и унаследовать интерфейс ICalculateFigureArea и реализовать метод GetArea.

```MBTestTask/MindBoxTestTask/Figures``` - содержит классы фигур.

```MBTestTask/MindBoxTestTask.Tests``` - содержит тесты для треугольника и круга.

## Задание №2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Схема БД:

```
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

```

```Products``` - таблица для продуктов

```Categories``` - таблица категорий

```ProductCategory``` - таблица для связей многие ко многим для связи продуктов и категорий

Запрос к БД для извлечения всех пар «Имя продукта – Имя категории»
```
select Products.ProductName, Categories.CategoryName
from Products
left join ProductCategory on Products.Id = ProductCategory.ProductId
left join Categories on Categories.Id = ProductCategory.CategoryId
```
