create procedure GetDate
as
select year(Date) as Year, month(Date) as Month, day(Date) as Day FROM dbo.MSFT 

