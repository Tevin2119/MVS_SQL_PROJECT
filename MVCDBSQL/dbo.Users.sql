CREATE TABLE [dbo].[Users] (
    [UserID]    INT         NOT NULL,
    [UserName]  NCHAR (100) UNIQUE NULL,
    [FirstName] NCHAR (150) NULL,
    [LastName]  NCHAR (150) NULL,
    [Email]     NCHAR (150) UNIQUE NULL,
    [IDnum]     NCHAR (10) UNIQUE NULL,
    [DOB]       DATE        NULL,
    [Phone]     NCHAR (25)  NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

