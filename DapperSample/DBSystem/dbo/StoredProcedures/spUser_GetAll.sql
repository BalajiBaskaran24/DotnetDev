CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
--Write actual SQL statements between begin and end
begin
--select *
select Id,FirstName,LastName
from dbo.[User];
end

