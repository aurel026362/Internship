Create DataBase trudogoliki;

use trudogoliki;

Create table MenthorsLog(
IdMenthor bigint identity(1,1) Primary Key, 
[Login] varchar(20) Not Null,
[Password] varchar(20) Not Null,
EMail varchar(30) check (EMail like '%@%') Not Null
);

Create table MenthorsPersonalData(
FirstName nvarchar(20) Not Null,
LastName nvarchar(20) Not Null,
DateOfBirth SMALLDATETIME Not Null,
NumberPhone nvarChar(15),
IdMenthor bigint Primary key Foreign Key References MenthorsLog(IdMenthor) Not Null
);

Create table PersonLog(
IdPerson bigint identity(1,1) Primary key,
[Login] varchar(20) Not Null,
[Password] varchar(20) Not Null,
[EMail] varchar(30) check ([EMail] like '%@%') Not Null,
[IdMenthor] bigint Foreign Key References MenthorsLog(IdMenthor) Not Null
);

Create table PersonData(
FirstName nvarchar(20) Not Null,
LastName nvarchar(20) Not Null,
DateOfBirth SMALLDATETIME Not Null,
Adress nvarchar(40),
NumberPhone nvarchar(20),
IdPerson bigint Primary key Foreign key References PersonLog(IdPerson)
);

Create table Modules(
IdModule bigint identity(1,1) Primary key,
NameModule nvarchar(30) Not Null,
StartDate time 
);

Create table Themes (
IdTheme bigint identity(1,1) Primary key, 
[Name] nvarchar(40) Not Null,
TimeOfTheme SMALLDATETIME,
[Source] nvarchar(40),
MenthorId bigint Foreign Key References MenthorsLog(IdMenthor),
ModuleId bigint Foreign Key References Modules(IdModule) Not Null
);

Create table ThemeNotes(
IdTheme bigint Foreign Key References Themes(IdTheme) Not Null,
IdPerson bigint Foreign Key References PersonLog(IdPerson) Not Null,
Note TINYINT check (Note> 0 AND Note <=10) Not Null);


Create table Examen(
[IdExamen] bigint identity(1,1) Primary key,
DateOfExamen SMALLDATETIME,
ModulId bigint Foreign Key References Modules(IdModule)
);

Create Table NotesExamen(
IdExamen bigint Foreign Key References Examen(IdExamen) Not Null,
IdPerson bigint Foreign Key References PersonLog(IdPerson) Not Null,
Note TINYINT check ([Note] >0 AND [Note] <=10)
);