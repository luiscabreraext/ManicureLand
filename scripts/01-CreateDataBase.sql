CREATE DATABASE [ManicureLand]
GO
USE [ManicureLand]
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](64) NOT NULL,
	[apellidoPaterno] [varchar](32) NOT NULL,
	[apellidoMaterno] [varchar](32) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[clave] [varchar](32) NOT NULL,
	[telefonoFijo] [varchar](32) NOT NULL,
	[telefonoMovil] [varchar](32) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[advertencias] [int] NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
