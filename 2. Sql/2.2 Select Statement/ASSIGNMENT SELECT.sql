USE ACDB;

SELECT packages.pack_id, packages.speed, Count(*) AS NumPacks
FROM packages INNER JOIN customers
ON packages.pack_id = customers.pack_id
GROUP BY packages.pack_id, packages.speed
HAVING Count(*)<80
ORDER BY 3


SELECT * FROM customers
WHERE monthly_discount IS NULL;

SELECT * FROM customers
WHERE monthly_discount IS NOT NULL;

SELECT customers.First_Name, customers.Last_Name, packages.speed
FROM customers LEFT JOIN packages
ON customers.pack_id = packages.pack_id;

SELECT customers.First_Name, customers.Last_Name, packages.speed
FROM customers RIGHT JOIN packages
ON customers.pack_id = packages.pack_id;

SELECT customers.First_Name, customers.Last_Name, packages.speed
FROM customers FULL JOIN packages
ON customers.pack_id = packages.pack_id;

SELECT customers.First_Name AS NUME,
	(SELECT  AVG(packages.monthly_payment)
	FROM customers 
	FULL JOIN packages
	ON customers.pack_id = packages.pack_id) AS SPEED
FROM customers 
FULL JOIN packages
ON customers.pack_id = packages.pack_id
`WHERE customers.First_Name like 'A%';