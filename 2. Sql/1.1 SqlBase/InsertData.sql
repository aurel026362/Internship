use MyDataBase;

--INSERT USERS
INSERT INTO Users(FirstName, LastName, DateOfBirth, NumberPhone, [Login], [Password], EMail)
VALUES ('Aurel', 'Starciuc', '1999-05-22', '+37367620932', 'aurel99', '12345', 'aur.99.s@mail.ru'),
		('Cristi', 'Anghelenici', '1996-06-15', '+373543677', 'cristi96', '54313', 'cristi@mail.ru'),
		 ('Ion', 'Gandrabura', '1984-02-02', '+37354395054', 'Ion12345', '432213', 'ion@mail.ru'),
		 ('Alexandr', 'Racovschi', '1987-07-20', '+3734325435', 'Alexandr789', 'under12345', 'alexandr@mail.ru'),
		 ('Ernest', 'Bitca', '1996-07-23', '+3736574835', 'ernestbitca', 'er1234', 'ernest@mail.ru'),
		 ('Oleg', 'Horan', '1986-05-12', '+3734356345', 'olegqwe', 'pass123', 'olhor@mail.ru');

		 SELECT * FROM USers;
		 SELECT * FROM Menthors;
		 SELECT * FROM Interns;

		 --INSERT MENTHORS
INSERT INTO Menthors(UserId)
VALUES (3),
		(4),
		(5);

		--INSERT INTERNS
Insert INTO Interns(UserId, MenthorId)
VALUES (5,5),
		(1,3),
		(2,4);

		--INSERT MODULES
INSERT INTO Modules(NameModule, StartDate)
VALUES ('C#', '2019-02-01'),
('SQL', '2019-03-01'),
('WEB', '2019-04-01');

SELECT * FROM Modules;

--INSERT THEME
INSERT INTO Themes([Name], TimeOfTheme, [Source], MenthorId, ModuleId)
VALUES ('GIT', '2019-02-02', 'S:\Internship', 4, 1),
('Select Advanced', '2019-03-13 09:30:00', 'S:\Internship', 3, 2),
('Sql Introduction', '2019-03-12 11:00', 'S:\Internship', 4,2);

SELECT * FROM Themes;

--INSERT ThemeMarks
INSERT INTO ThemeMarks(ThemeId, InternId, Mark)
VALUES	(1, 1, 9),
		(2, 1, 10),
		(1,2,7),
		(2,2,9),
		(3,2, 10),
		(3,5,10);

		SELECT * FROM ThemeMarks;

--INSERT Exams
INSERT INTO Exams(ModuleId, DateOfExamen)
VALUES (1, '2019-03-09'),
		(2, '2019-03-30'),
		(3, '2019-04-29');

		SELECT * FROM Exams;

--INSERT ExamMarks
INSERT INTO ExamMarks(ExamenId, InternId, Mark)
VALUES (1, 1, 8.7),
		(2, 1, 8),
		(3, 1, 9),
		(1, 2, 7),
		(2, 5, 10);

		select * from ExamMarks;