/*

*/

use AdventureWorks2012;

/*-1. Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) 
	to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’-*/
select sh.SalesOrderID,sh.ShipDate
from Sales.SalesOrderHeader sh
WHERE ShipDate >= '2002-07-28' AND ShipDate <= '2014-07-29'

-- 2. Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select pp.ProductID, pp.Name
from Production.Product pp
where pp.StandardCost < 110

-- 3. Display ProductID, Name if its weight is unknown
select pp.ProductID, pp.Name ,pp.Weight
from Production.Product pp
where pp.Weight is null

-- 4. Display all Products with a Silver, Black, or Red Color
select *
from Production.Product pp
where pp.Color='Silver' or pp.Color='Black' or pp.Color='Red'

-- 5. Display any Product with a Name starting with the letter B
select * 
from Production.Product pp
where pp.Name LIKE 'B%'

/*
6.	Run the following Query
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3
Then write a query that displays any Product description with underscore value in its description.
*/
update Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
where ProductDescriptionID = 3

select * 
from Production.ProductDescription pp
where pp.Description LIKE '%\_%' ESCAPE '\'

 /*7. Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table
	for the period between  '7/1/2001' and '7/31/2014'*/
select *
from Sales.SalesOrderHeader ss 
where ss.ShipDate >= '7-1-2001' and ss.ShipDate <= '7-31-2014'

-- 8. Display the Employees HireDate (note no repeated values are allowed)
select hre.HireDate
from HumanResources.Employee hre
order by hre.HireDate 

-- 9. Calculate the average of the unique ListPrices in the Product table
select avg(pp.ListPrice) Avrage
from Production.Product pp

/* 10. Display the Product Name and its ListPrice within the values of 100 and 120 
	  the list should has the following format "The [product name] is only! [List price]" 
	  (the list will be sorted according to its ListPrice value)*/
select pp.Name [product name] , pp.ListPrice [List price]
from Production.Product pp
where pp.ListPrice>=100 and pp.ListPrice<=120
order by pp.ListPrice

/*11.	
a)	Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table
	in a newly created table named [store_Archive]
	Note: Check your database to see the new table and how many rows in it?
b)	Try the previous query but without transferring the data? */

-- a)
select ss.rowguid , ss.Name , ss.SalesPersonID ,ss.Demographics
INTO store_Archive
from Sales.Store ss

select count(*) from store_Archive

-- b)
begin try
	SELECT rowguid, Name, SalesPersonID, Demographics
	INTO StoreArchive
	FROM Sales.Store
	WHERE 1=0
end try
begin catch
select ERROR_LINE() [error line], ERROR_MESSAGE() [error message]
end catch
select count(*) from StoreArchive

-- 12. Using union statement, retrieve the today’s date in different styles using convert or format funtion.
select convert(varchar, getdate(), 101)  DateStyle1
union
select FORMAT(GETDATE(), 'MMMM dd, yyyy') DateStyle2
union
select convert(varchar, getdate(), 106)  DateStyle3