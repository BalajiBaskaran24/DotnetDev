if not exists (Select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName,LastName)
	values ('Balaji','Baskaran'),
	('Sue','Storm'),
	('John','Smith'),
	('Mary','Jones');
end