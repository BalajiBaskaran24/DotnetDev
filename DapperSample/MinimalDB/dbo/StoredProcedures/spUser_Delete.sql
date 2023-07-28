CREATE PROCEDURE [dbo].[spUser_Delete]
	@id int = 0
AS
begin
delete
from dbo.[User]
where Id=@id;
end