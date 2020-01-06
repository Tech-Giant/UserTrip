CREATE TABLE [dbo].[ExpenseInfo]
(
	[ExpenseInfoId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Money] int not null,
	[Currency] nvarchar(20),
	[CurrencyCode] tinyint,
	[DebitCreditIndicator] tinyint,
	[CreatedBy] UNIQUEIDENTIFIER,
	[CreatedDate] datetime
)
