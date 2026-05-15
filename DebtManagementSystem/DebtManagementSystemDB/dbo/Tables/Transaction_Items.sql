CREATE TABLE [dbo].[Transaction_Items] (
    [TransactionItemID] INT             IDENTITY (1, 1) NOT NULL,
    [TransactionID]     INT             NOT NULL,
    [ProductID]         INT             NOT NULL,
    [Quantity]          INT             NOT NULL,
    [Price]             DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionItemID] ASC),
    FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ProductID])
);

