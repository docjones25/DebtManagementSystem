CREATE TABLE [dbo].[Transactions] (
    [TransactionID]   INT             IDENTITY (1, 1) NOT NULL,
    [CustomerID]      INT             NOT NULL,
    [TransactionDate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [TotalAmount]     DECIMAL (18, 2) NOT NULL,
    [Type]            NVARCHAR (50)   NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID])
);

