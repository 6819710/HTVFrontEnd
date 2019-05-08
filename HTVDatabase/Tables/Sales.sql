CREATE TABLE [dbo].[Sales]
(
	[invoice_id] INT NOT NULL,
	[date] DATE NOT NULL , 
    [customer_id] VARCHAR(10) NOT NULL, 
    [purchaced_vehicle] INT NOT NULL, 
    [purchace_price] MONEY NOT NULL, 
    [signature] IMAGE NOT NULL,  
    [staff_id] INT NOT NULL, 
    CONSTRAINT [FK_Sales_Vehicles] FOREIGN KEY ([purchaced_vehicle]) REFERENCES [Vehicles]([serial_Number]), 
    CONSTRAINT [FK_Sales_Customer] FOREIGN KEY ([customer_id]) REFERENCES [Customers]([customer_id]), 
    CONSTRAINT [PK_Sales] PRIMARY KEY ([invoice_id]), 
    CONSTRAINT [FK_Sales_Staff] FOREIGN KEY ([staff_id]) REFERENCES [Staff]([staff_id]) 
)
