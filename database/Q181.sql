# Write your MySQL query statement below
select e.Name from Employee e join Employee m
    on e.ManagerId = m.Id and e.Salary > m.Salary
