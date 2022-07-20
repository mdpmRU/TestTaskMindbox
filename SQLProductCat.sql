CREATE TABLE Goods (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Goods (Id, "Name")
VALUES 
(1, 'Bear'),
(2, 'Beer'),
(3, 'Car'),
(4, 'Airplane'),
(5, 'Bus');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories (Id, "Name")
VALUES 
(1, 'Gift'),
(2, 'Ground'),
(3, 'Drink');

CREATE TABLE GoodsWithCategories (
GoodsId INT FOREIGN KEY REFERENCES Goods(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (GoodsId, CategoryId)
);

INSERT INTO GoodsWithCategories
VALUES
(1,1),
(2,1),
(2,3),
(3,2),
(5,2);

SELECT P.Name, C.Name
FROM Goods P
LEFT JOIN GoodsWithCategories 
	ON P.Id = GoodsWithCategories.GoodsId
LEFT JOIN Categories C
	ON GoodsWithCategories.CategoryId = C.Id;