# Write your MySQL query statement below
select c.Name from Customers c
 where c.Id not in (select CustomerId from Orders)
