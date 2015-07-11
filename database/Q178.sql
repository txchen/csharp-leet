# Write your MySQL query statement below
select s.Score,
  (select count(*) + 1 from (select distinct Score from Scores) as t where Score > s.Score) as Rank
from Scores s order by s.Score desc
