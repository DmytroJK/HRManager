﻿CREATE TABLE [hrm].[UserLevel](
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(128) NOT NULL
	CONSTRAINT [PK_UserLevel] PRIMARY KEY ([Id])
)