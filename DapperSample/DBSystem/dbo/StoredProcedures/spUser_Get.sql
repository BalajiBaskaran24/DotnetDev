CREATE PROCEDURE [dbo].[spUser_Get]
	@id int = 0
AS
begin
select Id,FirstName,LastName
from dbo.[User]
where Id=@id;
end