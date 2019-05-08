CREATE TABLE [dbo].[DealerInstalledOptions]
(
	[option_id] INT NOT NULL PRIMARY KEY, 
    [option_description] VARCHAR(MAX) NOT NULL, 
    [option_base_cost] MONEY NOT NULL
)
