# Write your MySQL query statement below
select distinct(o.Num) from Logs o, Logs t, Logs th
 where o.Num = t.Num and o.Num = th.Num and o.Id + 1 = t.Id and o.Id + 2 = th.Id
