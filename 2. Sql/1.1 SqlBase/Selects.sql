use MyDataBase;

--SELECTS

SELECT * FROM Users;
SELECT * FROM Menthors;
SELECT * FROM Interns;
SELECT * FROM Modules;
SELECT * FROM Themes;
SELECT * FROM ThemeMarks;
SELECT * FROM Exams;
Select * FROM ExamMarks;

--Show All Interns
SELECT Users.FirstName, Users.LastName
FROM Users 
INNER JOIN Interns
ON Users.Id = Interns.UserId;

DELETE FROM Interns
WHERE UserId = 5;

--Show All Menthors
SELECT Users.FirstName, Users.LastName
FROM Users 
INNER JOIN Menthors
ON Users.Id = Menthors.UserId;

SELECT * FROM [dbo].[Interns] as i
INNER JOIN [dbo].[Menthors] as m ON m.UserId = i.MenthorId
INNER JOIN [dbo].[Users] as u ON u.Id = m.UserId
INNER JOIN [dbo].[Users] as u2 ON u2.Id = i.UserId
