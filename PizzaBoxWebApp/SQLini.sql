CREATE TABLE Users (
	ID int IDENTITY NOT NULL,
	FirstName varchar(128) NOT NULL,
	LastName varchar(128) NOT NULL,
	Street varchar(128) NOT NULL,
	City varchar(128) NOT NULL,
	State varchar (128) NOT NULL,
	ZipCode varchar(128) NOT NULL,
	Phone varchar(128) NOT NULL,
	Email varchar(128) NOT NULL,
	Password varchar(256) NOT NULL
)
GO

CREATE TABLE Location (
	ID int IDENTITY NOT NULL,
	Street varchar(128) NOT NULL,
	City varchar(128) NOT NULL,
	State varchar (128) NOT NULL,
	ZipCode varchar(128) NOT NULL,
	Phone varchar(128) NOT NULL
)
GO

CREATE TABLE Orders (
	ID int IDENTITY NOT NULL,
	OrderCost int NOT NULL,
	LocationID int NOT NULL, --FK
	UserID int NOT NULL --FK
)
GO

CREATE TABLE OrderDetails (
	ID int IDENTITY NOT NULL,
	PizzaName varchar(128) NOT NULL,
	Size varchar(10) NOT NULL,
	Crust varchar(10) NOT NULL,
	PizzaCost varchar(128) NOT NULL,
	OrderID int NOT NULL --FK
)
GO


-- PRIMARY KEYS

ALTER TABLE Users ADD
	CONSTRAINT PK_Users_ID PRIMARY KEY (ID);
GO

ALTER TABLE Location ADD
	CONSTRAINT PK_Location_ID PRIMARY KEY (ID);
GO

ALTER TABLE Orders ADD
	CONSTRAINT PK_Orders_ID PRIMARY KEY (ID);
GO

ALTER TABLE OrderDetails ADD
	CONSTRAINT PK_OrderDetails_ID PRIMARY KEY (ID);
GO


-- FOREIGN KEYS

ALTER TABLE Orders ADD
	CONSTRAINT FK_Order_Location
		FOREIGN KEY (LocationID) REFERENCES Location (ID);
GO

ALTER TABLE Orders ADD
	CONSTRAINT FK_Order_User
		FOREIGN KEY (UserID) REFERENCES Users (ID);
GO

ALTER TABLE OrderDetails ADD
	CONSTRAINT FK_OrderDetails_Order
		FOREIGN KEY (OrderID) REFERENCES Orders (ID);
GO


-- Adding dummy user
INSERT INTO Users (FirstName,LastName,Street,City,State,ZipCode,Phone,Email,Password) VALUES
('Jason','Parser','123 Main St','Arlington','Texas','76010','512-838-555','jasonparser@serializer.com','password123');
GO


-- Adding dummy locations
INSERT INTO Location (Street,City,State,ZipCode,Phone) VALUES
('9308 South Congress','Arlington','Texas','76010','217-555-555'),
('404 Lost Blvd','Dallas','Texas','76087','217-444-444'),
('2323 Kamehameha St','Honolulu','Hawaii','98099','980-999-999');
GO