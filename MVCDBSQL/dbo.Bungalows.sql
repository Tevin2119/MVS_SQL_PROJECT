CREATE TABLE [dbo].[Bungalows] (
    [BungalowID]   INT           NOT NULL,
    [Country]      NCHAR (100)   NULL,
    [Location]     NCHAR (100)   NULL,
    [Price]        NCHAR (100)   NULL,
    [Availability] DATETIME2 (7) NULL,
    [NumBedrooms]  INT           NULL,
    [NumBathrooms] INT           NULL,
    [NumFloors]    NCHAR (10)    NULL,
    [Squareacres]  NCHAR (10)    NULL,
    [TypeKitchen]  NCHAR (10)    NULL,
    [Garden]       BIT           NULL,
    [Age]          DATE          NULL,
    CONSTRAINT [PK_Bungalows] PRIMARY KEY CLUSTERED ([BungalowID] ASC)
);

