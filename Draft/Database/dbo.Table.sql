﻿CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(300) NOT NULL,
	[Number] INT NOT NULL,
	[Filters] VARCHAR(1000)
)