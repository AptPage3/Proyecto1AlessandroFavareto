USE [Proyecto1AlessandroFavaretoContext-20231107233909]
GO

/****** Objeto: Table [dbo].[Colaboradors] Fecha del script: 11/13/2023 9:11:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Colaboradors] (
    [Cedula]               INT            NOT NULL,
    [Nombre]               NVARCHAR (MAX) NULL,
    [Apellidos]            NVARCHAR (MAX) NULL,
    [CantidadHerramientas] INT            NOT NULL
);


