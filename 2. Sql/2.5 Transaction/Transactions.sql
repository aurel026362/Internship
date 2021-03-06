use MyDataBase;

--EXAMPLE AUTOCOMMIT
SELECT * FROM Users;
SELECT * FROM Interns;

--IMPLICIT TRANSACTION
SET IMPLICIT_TRANSACTIONS ON;

INSERT INTO USERS(FirstName, LastName, DateOfBirth, NumberPhone, Login, Password, EMail)
VALUES ('Cristi','Ciobanu', '1998-07-25', '+373685473543', 'cristibd','12345bd', 'cristi@mail.ru');

INSERT INTO Interns(GroupId, UserId)
VALUES (1, 9);

COMMIT TRANSACTION;

--EXPLICIT TRANSACTION
SET IMPLICIT_TRANSACTION OFF;

BEGIN TRANSACTION 
DELETE FROM Interns WHERE Id = 5;
COMMIT TRANSACTION;
