# Write your MySQL query statement below
select DISTINCT p.Email from Person p, Person q where p.Id != q.Id and p.Email = q.Email
