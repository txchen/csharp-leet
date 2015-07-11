CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
  set N = N - 1;
  RETURN (
      select max(Salary) from Employee group by Salary order by Salary DESC limit N,1
  );
END
