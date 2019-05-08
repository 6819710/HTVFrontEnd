CREATE TABLE [dbo].[DealerInstalledOptionsSales]
(
	[option_id] INT NOT NULL , 
    [invoice_id] INT NOT NULL, 
    PRIMARY KEY ([invoice_id], [option_id]), 
    CONSTRAINT [FK_DealerInstalledOptionsSales_DealerInstalledOptions] FOREIGN KEY ([option_id]) REFERENCES [DealerInstalledOptions]([option_id]), 
    CONSTRAINT [FK_DealerInstalledOptionsSales_Sales] FOREIGN KEY ([invoice_id]) REFERENCES [Sales]([invoice_id])
)
