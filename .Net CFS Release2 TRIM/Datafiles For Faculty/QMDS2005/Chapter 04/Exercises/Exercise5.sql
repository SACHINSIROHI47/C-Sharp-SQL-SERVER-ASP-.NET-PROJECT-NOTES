-- 1. Create the Category table by using the following statement:
--===============================================================

CREATE TABLE Category
(
CategoryID char(3) CONSTRAINT pkCategoryID PRIMARY KEY,
Category char(20) CONSTRAINT unqCategory UNIQUE,
Description varchar(100) NULL
)


--2. Create the ProductBrand table by using the following statement:
--===============================================================

CREATE TABLE ProductBrand
(
BrandID char(3) CONSTRAINT pkBrandID PRIMARY KEY,
BrandName char(20) CONSTRAINT unqBrandName UNIQUE,
)


--3. Create the NewProduct table by using the following statement:
--===============================================================

CREATE TABLE NewProduct
(
ProductID char(6) CONSTRAINT pkProductID PRIMARY KEY,
ProductName varchar(20) NOT NULL,
ProductDescription varchar(250) NOT NULL,
CategoryID char(3)CONSTRAINT fkCategoryID FOREIGN KEY REFERENCES Category(CategoryID) ,
ProductRate money,
BrandID char(3),
Photo image NULL,
Qoh smallint CONSTRAINT chkQoh CHECK(Qoh BETWEEN 0 AND 200),
ProductImgPath varchar(50) NULL
)


--4. Modify the NewProduct table by using the following statement:
--================================================================

ALTER TABLE NewProduct
ADD CONSTRAINT fkBrandID FOREIGN KEY (BrandID) REFERENCES ProductBrand(BrandID)
