CREATE TABLE [dbo].[UserExpenseInfo]
(
	[UserExpenseInfoId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	[ExpenseInfoId] UNIQUEIDENTIFIER NOT NULL,
	[Note] nvarchar(max),
	[CreatedBy] UNIQUEIDENTIFIER,
	[CreatedDate] datetime
)
