USE [Proyecto1AlessandroFavaretoContext-20231107233909]
GO

/****** Objeto: Table [dbo].[Herramientas] Fecha del script: 11/13/2023 9:11:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Herramientas] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [nombre]        NVARCHAR (MAX) NULL,
    [descripcion]   NVARCHAR (MAX) NULL,
    [fechaPrestamo] DATETIME       NULL,
    [fechaDevolver] DATETIME       NULL
);


