Create table Interns(
Id bigint identity(1,1) Primary key,
GroupId bigint FOREIGN KEY REFERENCES Groups(Id) Not Null,
UserId bigint Foreign Key References Users(Id) Not Null UNIQUE,
MenthorId bigint Foreign Key References Menthors(Id) UNIQUE,
);