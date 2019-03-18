
use ACDB;

--1
SELECT First_Name, Last_Name, [City], [State] 
FROM customers 
WHERE State = 
	(SELECT State
	FROM customers 
	WHERE Customer_Id = 170);

--2
SELECT pack_id, speed, sector_id 
FROM packages 
WHERE sector_id= 
	(SELECT sector_id 
	FROM packages 
	WHERE pack_id = 10);

--3
SELECT First_Name, Last_Name, Join_Date
FROM customers 
WHERE Join_Date>
	(SELECT Join_Date
	FROM customers 
	WHERE Customer_Id = 540);

--4
SELECT First_Name, Last_Name, Join_Date
FROM customers 
WHERE Year(Join_Date) = 
	( Select Year(Join_Date)
	FROM customers 
	WHERE Customer_Id = 372)
	AND Month(Join_Date) = 
		(Select Month(Join_Date)
		FROM customers 
		WHERE Customer_Id = 372);

--5
SELECT First_Name, Last_Name, State, City, pack_id
FROM customers
WHERE pack_id in 
	(SELECT pack_id 
	FROM packages 
	WHERE speed = '5Mbps');

--6
SELECT pack_id, speed, strt_date
FROM packages
WHERE YEAR(strt_date)=
	(SELECT YEAR(strt_date)
	FROM packages
	WHERE 
	pack_id = 7);

--7
SELECT First_Name, monthly_discount, packages.pack_id, main_phone_num, secondary_phone_num, sectors.sector_name
FROM customers 
INNER JOIN packages ON customers.pack_id = packages.pack_id
INNER JOIN sectors ON packages.sector_id = sectors.sector_id
WHERE sectors.sector_name = 'Business';

SELECT First_Name, monthly_discount, pack_id, main_phone_num, secondary_phone_num
FROM customers 
WHERE pack_id IN 
	(SELECT pack_id 
	FROM packages INNER JOIN sectors 
	ON packages.sector_id = sectors.sector_id
	WHERE sectors.sector_name=  'Business');

--8
SELECT First_Name, monthly_discount, packages.pack_id, packages.monthly_payment
FROM customers 
INNER JOIN packages ON customers.pack_id = packages.pack_id
WHERE packages.monthly_payment> 
		(SELECT AVG(monthly_payment)
		FROM packages);

--9
SELECT First_Name, City, [State], Birth_Date, monthly_discount
FROM customers
WHERE Birth_Date = 
	(SELECT Birth_Date 
	FROM customers 
	WHERE Customer_Id = 179)
	AND 
		monthly_discount>
			(SELECT monthly_discount
			FROM customers
			WHERE Customer_Id = 107);

--10
SELECT * FROM packages
WHERE speed = 
	(SELECT speed 
	FROM packages
	WHERE pack_id = 30)
	AND monthly_payment>
		(SELECT monthly_payment
		FROM packages
		WHERE pack_id = 7);

--11
SELECT pack_id, speed, monthly_payment
FROM packages 
WHERE monthly_payment > 
	(SELECT MAX(monthly_payment)
	FROM packages
	WHERE speed = '5Mbps');

--12
SELECT pack_id, speed, monthly_payment
FROM packages 
WHERE monthly_payment > 
	(SELECT Min(monthly_payment)
	FROM packages
	WHERE speed = '5Mbps');

--13
SELECT pack_id, speed, monthly_payment
FROM packages
WHERE monthly_payment<
	(SELECT Min(monthly_payment)
	FROM packages
	WHERE speed = '5Mbps'); 

--14
SELECT First_Name, monthly_discount, pack_id 
FROM customers 
WHERE monthly_discount < 
	( SELECT AVG(monthly_discount)
	FROM customers )
	AND 
		pack_id = (SELECT pack_id 
					FROM customers
					WHERE First_Name = 'Kevin'); 

--Aditional selects

SELECT *
FROM customers
WHERE monthly_discount > ANY
	( SELECT monthly_discount*1.5
	FROM customers);

SELECT *
FROM customers
WHERE monthly_discount > ALL
	( SELECT (monthly_payment/10)
	FROM packages);

SELECT * 
FROM pack_grades
WHERE min_price <
	(SELECT (max_price*monthly_discount) 
	FROM customers
	WHERE Customer_Id = 1);


	UPDATE customers
	SET First_Name = 'NewValue'
	FROM customers
	INNER JOIN packages
	ON packages.pack_id = customers.pack_id
	WHERE packages.speed = '7Mbps';

SELECT * ,
	case City
		WHEN 'New York' THEN (City+' Best')
		WHEN 'Los Angeles' THEN (City+' Good')
			ELSE (City+' NO')
	END AS NEWCITY
FROM customers;

SELECT *, 
	Case 
	WHEN monthly_discount>20 THEN 'best'
	WHEN monthly_discount>=10 THEN 'good'
	else 'bad'
	end AS TYPEDiscount
FROM customers;
	

SELECT *, iif(monthly_discount>10,'good discount', 'bad discount')
FROM customers;
