Create table Menthors(
Id bigint identity(1,1) Primary Key,
UserId bigint Foreign Key References Users(Id) Not Null UNIQUE,
);