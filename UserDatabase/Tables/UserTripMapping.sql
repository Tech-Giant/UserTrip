CREATE TABLE [dbo].[UserTripMapping]
(
	[UserTripId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	[TripId] UNIQUEIDENTIFIER NOT NULL,
	[CreatedBy] UNIQUEIDENTIFIER,
	[CreatedDate] datetime,
	[ModifiedBy] UNIQUEIDENTIFIER,
	[ModifiedDate] datetime
)
