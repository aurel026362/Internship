
Create table ThemeMarks(
Id bigint identity(1,1) Primary Key,
ThemeId bigint Foreign Key References Themes(Id) Not Null,
InternId bigint Foreign Key References Interns(Id) Not Null,
Mark float check (Mark> 0 AND Mark <=10) Not Null
);