CREATE TABLE [dbo].[AQLogTable] (
    [RowId]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [ContentType]     VARCHAR (50)     DEFAULT ('PLAIN/TEXT') NULL,
    [Type]            VARCHAR (50)     DEFAULT ('INFO') NULL,
    [Content]         NVARCHAR (MAX)   NOT NULL,
    [ApplicationName] VARCHAR (150)    NOT NULL,
    [CreateDate]      DATETIME         DEFAULT (getdate()) NULL,
    [ChannelName]     VARCHAR (100)    DEFAULT ('Default') NULL,
    [Tag]             VARCHAR (80)     DEFAULT ('Default') NULL,
    [Author]          VARCHAR (100)    DEFAULT ('System') NULL,
    [Header]          NVARCHAR (150)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RowId] ASC)
);



CREATE TABLE [dbo].[AQLogTable] (
    [RowId]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [ContentType]     VARCHAR (50)     DEFAULT ('PLAIN/TEXT') NOT NULL,
    [Type]            VARCHAR (50)     DEFAULT ('INFO') NOT NULL,
    [Content]         NVARCHAR (MAX)   DEFAULT ('') NOT NULL,
    [ApplicationName] VARCHAR (150)    DEFAULT ('') NOT NULL,
    [CreateDate]      DATETIME         DEFAULT (getdate()) NOT NULL,
    [ChannelName]     VARCHAR (100)    DEFAULT ('Default') NOT NULL,
    [Tag]             VARCHAR (80)     DEFAULT ('Default') NOT NULL,
    [Author]          VARCHAR (100)    DEFAULT ('System') NOT NULL,
    [Header]          NVARCHAR (150)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RowId] ASC)
);

