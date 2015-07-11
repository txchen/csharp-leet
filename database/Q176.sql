# Write your MySQL query statement below
select max(Salary) from Employee
 where Salary not in (select max(Salary) from Employee)
