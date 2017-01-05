﻿CREATE TABLE [dbo].[CustomerPackageTasks]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [CustomerID] INT NOT NULL, 
    [PackageID] INT NOT NULL, 
    CONSTRAINT [PK_CustomerTasks] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_CustomerPackageTasks_CustomerPackages] FOREIGN KEY (CustomerID, PackageID) REFERENCES [CustomerPackages](CustomerID, PackageID)
)
