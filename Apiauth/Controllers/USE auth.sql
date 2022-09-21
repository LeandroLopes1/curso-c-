USE auth;
GO

SELECT * FROM dbo.Users;

INSERT INTO dbo.Users (Username, Password, Role) VALUES ('batman', 'batman', 'admin');
GO