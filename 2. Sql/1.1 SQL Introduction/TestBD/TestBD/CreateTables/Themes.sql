Create table Themes (
Id bigint identity(1,1) Primary key, 
[Name] nvarchar(40) Not Null,
TimeOfTheme SMALLDATETIME,
[Source] nvarchar(40),
MenthorId bigint Foreign Key References Menthors(Id),
ModuleId bigint Foreign Key References Modules(Id) Not Null
);