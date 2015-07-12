# Write your MySQL query statement below

select d.Name as Department, e.Name as Employee, ts.Salary
from (select max(Salary) as Salary, DepartmentId
  from Employee group by DepartmentId) ts
join Department d
  on d.Id = ts.DepartmentId
join Employee e
  on e.Salary = ts.Salary and e.DepartmentId = d.Id
