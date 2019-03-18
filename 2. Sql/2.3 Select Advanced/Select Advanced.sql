use ACDB;
--1
Select Top 1 Last_Name 
FROM customers
Order By Last_Name ASC;

--1
SELECT MIN(Last_Name)
FROM customers;

--2 
SELECT AVG(monthly_payment) AS AVERAGE
FROM packages;

--4 
Select Top 1 Last_Name 
FROM customers
Order By Last_Name DESC;

--4
SELECT MAX(Last_Name)
FROM customers;

SELECT COUNT(*)
FROM packages;

--5
SELECT Count(*) AS NrCust
FROM customers;

--6 
SELECT Count( Distinct [state]) AS NRDistinct
FROM customers

--7
SELECT Count( Distinct [speed]) AS NrDistinct
FROM packages;

--8
SELECT Count(*) 
FROM customers
WHERE fax IS NOT NULL;


--9
SELECT Count(*) 
FROM customers
WHERE fax IS NULL;

--10
SELECT Max(monthly_discount), Min(monthly_discount), AVG(monthly_discount)
FROM customers;

--GROUP By---

--1
SELECT [state], Count(*)
FROM customers
GROUP By [state];

--2
SELECT packages.speed, AVG(monthly_payment) AS AVGPAYMENT
FROM packages
GROUP BY packages.speed;

--3
SELECT [state], COUNT(Distinct [city]) AS DistCities
FROM customers
GROUP BY state;

--4
SELECt sectors.sector_id, MAX(monthly_payment)
FROM sectors
LEFT JOIN packages
ON sectors.sector_id = packages.pack_id
GROUP BY sectors.sector_id;

--4
SELECT sector_id, MAX(monthly_payment)
FROM packages
GROUP BY sector_id;

--5
SELECT pack_id, AVG(monthly_discount) 
FROM customers
WHERE pack_id IS NOT NULL
GROUP By pack_id;

--6
SELECT packages.pack_id, AVG (monthly_discount)
FROM packages
LEFT JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id;

--7
SELECT packages.pack_id, AVG (monthly_discount)
FROM packages
LEFT JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id
HAVING packages.pack_id = 13 OR packages.pack_id = 22;

--8
SELECT speed, MIN(monthly_payment) AS MINIMUM, MAX(monthly_payment) AS MAXIMUM, AVG(monthly_payment) AS MEDIUM
FROM packages
GROUP BY speed;

--9
SELECT packages.pack_id, COUNT (customers.Customer_Id) AS NR
FROM packages
LEFT JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id;

--10
SELECt packages.pack_id, COUNT(customers.Customer_Id) AS NR 
FROM packages 
INNER JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id;

--11
SELECt packages.pack_id, COUNT(customers.Customer_Id) AS NR 
FROM packages 
LEFT JOIN customers
ON packages.pack_id = customers.pack_id
WHERE customers.monthly_discount>20
GROUP BY packages.pack_id;

--12
SELECt packages.pack_id, COUNT(customers.Customer_Id) AS NR 
FROM packages 
LEFT JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id
HAVING COUNT(customers.Customer_Id)>100;

--13
Select state, city, COUNT (*) AS NR
FROM customers
GROUP BY state, city
ORDER BY state;

--14
SELECT city, AVG(monthly_discount) AS AVERAGE
FROM customers
GROUP By city;

--15
SELECT city, AVG(monthly_discount) AS AVERAGE
FROM customers 
GROUP BY city;

--16
SELECT city, AVG(monthly_discount) AS AVERAGE
FROM customers 
WHERE monthly_discount>20
GROUP BY city;

--17
Select state, Min(monthly_discount) AS MINIMUM
FROM customers
GROUP BY state;

--18
Select state, Min(monthly_discount) AS MINIMUM
FROM customers
GROUP BY state;

--19
Select state, Min(monthly_discount) AS MINIMUM
FROM customers
WHERE monthly_discount>10
GROUP BY state;

--20
SELECT speed, COUNT(*)
FROM packages 
GROUP BY speed
HAVING COUNT(*)>8;



INSERT INTO pack_grades(grade_name, min_price, max_price)
	SELECT state, Customer_Id, pack_id
	FROM customers;

DELETe FROM pack_grades
	OUTPUT deleted.grade_name, deleted.min_price, deleted.max_price
	WHERE grade_name in (
	SELECT [state]
	FROM customers
	);

	drop table MyTable;

	CREATE TABLE MyTable(
	Customer_Id int,
	FirstName nvarchar(20)
	);

	INSERT INTO MyTable
	VALUES (18655,'Ion'),
			(20987654,'Alex'),
			(1, 'Alvin'),
			(3, 'Amado');
			
			SELECT * FROM MyTable;
			SELECT * FROM customers;

Merge INTO MyTable AS mt
	USING customers AS c
	ON c.Customer_Id = mt.Customer_Id
	
		WHEN MATCHED THEN 
		UPDATE SET mt.FirstName = 'Egal'

		WHEN NOT Matched By source then 
		UPDATE SET mt.FirstName = 'Difera'
		
		WHEN NOT MATCHED then
		INSERT (Customer_Id, FirstName) VALUES(77777,'NEW');

		TRUNCATE TABLE MyTable;

		DELETE m
		FROM MyTable m
		INNER JOIN customers AS c 
		ON m.FirstName = c.First_Name
		WHERE c.City = 'New York';

		UPDATE m
		SET m.FirstName = 'asd'
		FROM MyTable m
		INNER JOIN customers c
		ON m.FirstName = c.First_Name
		

		SELECT First_Name, Last_Name, main_phone_num
		INTO FakeTable
		FROM customers
		WHERE First_Name = 'Adam';

		SELECT * FROM FakeTable;

		Drop Table FakeTable;

