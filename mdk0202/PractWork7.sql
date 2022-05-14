--1
CREATE TABLE Promotions
(
	IdPromotion int NOT NULL IDENTITY,
	Name nvarchar(50) NOT NULL,
	Description nvarchar(200) NULL,
	Discount int NOT NULL,
	DateOfStart date DEFAULT Cast(GetDate() as date) NOT NULL,
	DateOfEnd date NULL,

	PRIMARY KEY (IdPromotion)
)

--2
CREATE TABLE PromotedProducts
(
	IdPromotion int NOT NULL,
	IdProduct int NOT NULL,

	PRIMARY KEY (IdPromotion, IdProduct),

	CONSTRAINT FK_PromotedProducts_Products
	FOREIGN KEY (IdProduct)
	REFERENCES Products(IdProduct)
	ON DELETE NO ACTION
	ON UPDATE CASCADE,

	CONSTRAINT FK_PromotedProducts_Promotions
	FOREIGN KEY (IdPromotion)
	REFERENCES Promotions(IdPromotion)
	ON DELETE CASCADE
	ON UPDATE CASCADE
)

--3
ALTER TABLE Promotions
ADD DiscountType nvarchar(5) DEFAULT '%' NOT NULL

--4
ALTER TABLE Promotions
ADD CONSTRAINT CK_DiscountType
CHECK (DiscountType = '%' OR DiscountType = 'руб.');

ALTER TABLE Promotions
ADD CONSTRAINT CK_Discount
CHECK (Discount > 0);

--5
ALTER TABLE Promotions
ADD CONSTRAINT UQ_Promotions
UNIQUE (Name, DateOfStart)

--6
ALTER TABLE PromotedProducts
DROP CONSTRAINT FK_PromotedProducts_Promotions

DROP TABLE Promotions