CREATE DATABASE [ManicureLand]
GO
USE [ManicureLand]
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](64) NOT NULL,
	[apellidoPaterno] [varchar](32) NOT NULL,
	[apellidoMaterno] [varchar](32) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[clave] [varchar](32) NOT NULL,	
	[telefono] [varchar](12) NULL,
	[fechaRegistro] [date] NOT NULL,
	[advertencias] [int] NOT NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](64) NOT NULL,
	[apellidoPaterno] [varchar](32) NOT NULL,
	[apellidoMaterno] [varchar](32) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[rut] [varchar](10) NULL,
	[correo] [varchar](255) NOT NULL,
	[clave] [varchar](32) NOT NULL,	
	[telefono] [varchar](12) NULL,
	[fechaRegistro] [date] NOT NULL,
	[perfil] [int] NOT NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](32) NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[observacion] [varchar](255) NULL,	
	[codigoColor] [varchar](6) NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Diseno](
	[idDiseno] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](32) NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[observacion] [varchar](255 NULL),
	[urlDiseno] [varchar](MAX) NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] IDENTITY(1,1) NOT NULL,
	[idManicurista] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precioTotal] [int] NOT NULL,
	[observacion] [varchar](255) NULL,
	[fechaRegistroReserva] [datetime] NOT NULL,
	[fechaReserva] [datetime] NOT NULL,
	[horaLlegada] [time] NOT NULL,
	[horaInicioServicio] [time] NOT NULL,
	[horaTercminoServicio] [time] NOT NULL,
	[estado] [char](1) NOT NULL
	)
GO

CREATE TABLE [dbo].[Dedo](
	[idDedo] [int] IDENTITY(1,1) NOT NULL,
	[extremidad] [CHAR][2] NOT NULL,
	[descripción] [int] NOT NULL	
	)
GO

CREATE TABLE [dbo].[Turno](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[idManicurista] [int] NOT NULL,	
	[fechaInico] [datetime] NOT NULL,
	[fechatermino] [datetime] NOT NULL,
	[horaInicio] [time] NOT NULL,
	[horaTermino] [time] NOT NULL,
	[horaInicioColacion] [time] NOT NULL,
	[horaTerminoColacion] [time] NOT NULL
	)
GO

CREATE TABLE [dbo].[CatalogoServicio](
	[idServicio] [int] NOT NULL,
	[idManicurista] [int] NOT NULL
	)
GO

CREATE TABLE [dbo].[CatalogoDiseno](
	[idDiseno] [int] NOT NULL,
	[idManicurista] [int] NOT NULL
	)
GO

CREATE TABLE [dbo].[ReservaDedo](
	[idReserva] [int] NOT NULL,
	[idDedo] [int] NOT NULL,
	[idDiseno] [int] NOT NULL
	)
GO

CREATE TABLE [dbo].[ReservaServicio](
	[idReserva] [int] NOT NULL,
	[idServicio] [int] NOT NULL
	)
GO
