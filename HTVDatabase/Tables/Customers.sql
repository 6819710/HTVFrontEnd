CREATE TABLE [dbo].[Customers]
(
	[customer_id] VARCHAR(10) NOT NULL , 
    [name] VARCHAR(MAX) NOT NULL, 
    [address] VARCHAR(MAX) NOT NULL, 
    [phone_number_primary] VARCHAR(50) NOT NULL, 
    [phone_number_secondary] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Customers] PRIMARY KEY ([customer_id])
)
