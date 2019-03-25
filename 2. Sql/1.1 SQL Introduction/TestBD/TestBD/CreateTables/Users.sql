
Create table Users(
Id bigint identity(1,1) Primary key,
FirstName nvarchar(20) Not Null,
LastName nvarchar(20) Not Null,
DateOfBirth SMALLDATETIME Not Null,
NumberPhone nvarChar(15),
[Login] varchar(20) Not Null,
[Password] varchar(20) Not Null,
EMail varchar(30) check (EMail like '%@%') Not Null
);
