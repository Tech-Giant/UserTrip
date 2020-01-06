CREATE TABLE [dbo].[TripDetails]
(
	[TripId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[TripName] nvarchar(200) Not NUll,
	[TripDetails] nvarchar(max),
	[CreatedBy] UNIQUEIDENTIFIER,
	[CreatedDate] datetime
)
