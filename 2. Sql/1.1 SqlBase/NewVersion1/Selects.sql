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

--Show All Menthors
SELECT Users.FirstName, Users.LastName
FROM Users 
INNER JOIN Menthors
ON Users.Id = Menthors.UserId;

--Show All Menthors and her Interns
SELECT u.FirstName, u.LastName, u2.FirstName, u2.LastName 
FROM [dbo].[Interns] as i
INNER JOIN [dbo].[Menthors] as m ON m.Id = i.MenthorId
INNER JOIN [dbo].[Users] as u ON u.Id = m.UserId
INNER JOIN [dbo].[Users] as u2 ON u2.Id = i.UserId

--Show All Menthors and her Themes
SELECT u.FirstName, u.LastName, t.Name
FROM Users u
INNER JOIN Menthors
ON u.Id = Menthors.UserId
INNER JOIN Themes t
ON Menthors.Id = t.MenthorId;

--SHOW ALL Marks for each interns
SELECT u.FirstName, u.LastName, t.Name, m.Mark
FROM Users u 
LEFT JOIN Interns ON u.Id = Interns.UserId
INNER JOIN ThemeMarks m ON Interns.Id = m.InternId
INNER JOIN Themes t ON m.ThemeId = t.Id;

--Show ALL Interns and her Marks
SELECT u.FirstName, u.LastName, t.Name, men.FirstName, m.Mark
FROM Users u 
inner JOIN Interns ON u.Id = Interns.UserId
full JOIN ThemeMarks m ON Interns.Id = m.InternId
full JOIN Themes t ON m.ThemeId = t.Id
full JOIN Menthors ON t.MenthorId = Menthors.Id 
full JOIN Users men ON Menthors.UserId = men.Id
WHERE u.FirstName IS NOT NULL;

--SELECT nr of marks for each theme 
SELECT t.Name AS [Theme Name], COUNT(*) AS NrMarks
FROM Themes t 
LEFT JOIN ThemeMarks m ON t.Id = m.ThemeId
GROUP BY t.Name;
