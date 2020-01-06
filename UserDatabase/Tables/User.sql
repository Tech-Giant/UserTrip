CREATE TABLE [dbo].[User]
(
	[UserId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Name] varchar(100) NOT NULL,
	[Mobile] varchar(20) NOT NULL,
	[Email] varchar(100) NOT NULL,
	[Address] varchar(200) NUll,
	[UserProof] nvarchar(max) NULL,
	[CreatedBy] UNIQUEIDENTIFIER,
	[CreatedDate] datetime
)
