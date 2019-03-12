USE ACDB;

--1.a
SELECT customers.First_Name, customers.Last_Name, packages.pack_id, packages.speed 
FROM customers 
INNER JOIN packages
ON customers.pack_id = packages.pack_id
ORDER By packages.pack_id;

--1.b
SELECT c.First_Name, c.Last_Name, p.pack_id, p.speed
FROM customers c 
INNER JOIN packages p
ON c.pack_id = p.pack_id
WHERE p.pack_id = 23 OR p.pack_id = 27
ORDER BY c.Last_Name Asc,
p.pack_id DESC;



--2.a
SELECT packages.pack_id, packages.speed, packages.monthly_payment, sectors.sector_name
FROM packages 
INNER JOIN sectors
ON packages.sector_id = sectors.sector_id;

--2.b
SELECT customers.First_Name, customers.Last_Name, packages.pack_id, packages.speed, packages.monthly_payment, sectors.sector_name
FROM customers 
INNER JOIN packages
ON customers.pack_id = packages.pack_id
INNER JOIN sectors
ON packages.sector_id = sectors.sector_id;

--2.c 
SELECT customers.First_Name, customers.Last_Name, packages.pack_id, packages.speed, packages.monthly_payment, sectors.sector_name
FROM customers 
INNER JOIN packages
ON customers.pack_id = packages.pack_id
INNER JOIN sectors
ON packages.sector_id = sectors.sector_id
WHERE sectors.sector_name='Business';

--3.a
SELECT customers.First_Name, customers.Last_Name, customers.Join_Date, packages.pack_id, packages.speed, sectors.sector_name
FROM customers 
INNER JOIN packages
ON customers.pack_id = packages.pack_id
INNER JOIN sectors
ON packages.sector_id = sectors.sector_id
WHERE sectors.sector_name = 'Private'
AND year(customers.Join_Date)=2006;


--4.a
SELECT customers.First_Name, customers.Last_Name, packages.speed, packages.monthly_payment
FROM customers 
LEFT JOIN packages
ON customers.pack_id = packages.pack_id
WHERE customers.pack_id IS NOT NULL;

--4.b
SELECT customers.First_Name, customers.Last_Name, packages.speed, packages.monthly_payment
FROM customers 
LEFT JOIN packages
ON customers.pack_id = packages.pack_id;

--4.c
SELECT customers.First_Name, customers.Last_Name, packages.speed, packages.monthly_payment
FROM customers 
RIGHT JOIN packages
ON customers.pack_id = packages.pack_id;

--4.d
SELECT customers.First_Name, customers.Last_Name, packages.speed, packages.monthly_payment
FROM customers 
FULL JOIN packages
ON customers.pack_id = packages.pack_id;