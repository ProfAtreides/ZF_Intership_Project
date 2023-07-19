CREATE TABLE [dbo].[Items] (
    [Id]       INT            NOT NULL,
    [Name]     VARCHAR (300)  NOT NULL,
    [Quantity] INT            NOT NULL,
    [Filters]  VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

