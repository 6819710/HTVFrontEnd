CREATE TABLE [dbo].[TradeInVehicles]
(
	[serial_number] INT NOT NULL , 
    [invoice_id] INT NOT NULL, 
    [tradein_allowance] MONEY NOT NULL, 
    CONSTRAINT [FK_TradeInVehicles_Vehicles] FOREIGN KEY ([serial_number]) REFERENCES [Vehicles]([serial_number]), 
    CONSTRAINT [FK_TradeInVehicles_Sales] FOREIGN KEY ([invoice_id]) REFERENCES [Sales]([invoice_id]), 
    CONSTRAINT [PK_TradeInVehicles] PRIMARY KEY ([invoice_id], [serial_number])
)
