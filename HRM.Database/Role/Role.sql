﻿CREATE TABLE [hrm].[Role](
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(16) NOT NULL
	CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
)