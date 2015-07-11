# Write your MySQL query statement below
select t.Id
  from Weather t
  join Weather y
    on y.Date = subdate(t.Date, 1)
 where t.Temperature > y.Temperature
