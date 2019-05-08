CREATE TABLE [dbo].[Vehicles]
(
    [serial_number] INT NOT NULL, 
    [name] VARCHAR(MAX) NOT NULL,
	[model] VARCHAR(MAX) NOT NULL,
	[year]	INT NOT NULL DEFAULT 2019,
	[manufacturer] VARCHAR(MAX) NOT NULL,
	[base_cost]	MONEY NOT NULL, 
    CONSTRAINT [PK_Vehicles] PRIMARY KEY ([serial_number])
)
