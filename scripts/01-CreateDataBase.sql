CREATE DATABASE [ManicureLand]
GO

USE [ManicureLand]
GO

CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](64) NOT NULL,
	[apellidoPaterno] [varchar](32) NOT NULL,
	[apellidoMaterno] [varchar](32) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[correo] [varchar](255) NOT NULL UNIQUE,
	[clave] [varchar](32) NOT NULL,	
	[telefono] [varchar](12) NULL,
	[fechaRegistro] [date] NOT NULL,
	[advertencias] [int] NOT NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](64) NOT NULL,
	[apellidoPaterno] [varchar](32) NOT NULL,
	[apellidoMaterno] [varchar](32) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[rut] [varchar](10) NULL,
	[correo] [varchar](255) NOT NULL UNIQUE,
	[clave] [varchar](32) NOT NULL,	
	[telefono] [varchar](12) NULL,
	[fechaRegistro] [date] NOT NULL,
	[perfil] [int] NOT NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](64) NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[observacion] [varchar](255) NULL,	
	[codigoColor] [varchar](6) NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Diseno](
	[idDiseno] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](64) NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[observacion] [varchar](255) NULL,
	[urlDiseno] [varchar](MAX) NULL,
	[estado] [bit] NOT NULL
	)
GO

CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[idManicurista] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[tiempoEstimado] [int] NOT NULL,
	[precioTotal] [int] NOT NULL,
	[observacion] [varchar](255) NULL,
	[fechaRegistroReserva] [datetime] NOT NULL,
	[fechaReserva] [datetime] NOT NULL,
	[horaLlegada] [time](0) NULL,
	[horaInicioServicio] [time](0) NULL,
	[horaTerminoServicio] [time](0) NULL,
	[estado] [char](1) NOT NULL
	)
GO

CREATE TABLE [dbo].[Dedo](
	[idDedo] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[extremidad] [CHAR](2) NOT NULL,
	[descripcion] [varchar](32) NOT NULL	
	)
GO

CREATE TABLE [dbo].[Turno](
	[idTurno] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[idManicurista] [int] NOT NULL,	
	[fechaInico] [datetime] NOT NULL,
	[fechaTermino] [datetime] NOT NULL,
	[horaInicio] [time](0) NOT NULL,
	[horaTermino] [time](0) NOT NULL,
	[horaInicioColacion] [time](0) NOT NULL,
	[horaTerminoColacion] [time](0) NOT NULL
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

------------------- CREACION DE LLAVES FORANEAS -------------------

ALTER TABLE [dbo].[CatalogoDiseno]  WITH CHECK ADD  CONSTRAINT [FK_CatalogoDiseno_Diseno] FOREIGN KEY([idDiseno])
REFERENCES [dbo].[Diseno] ([idDiseno])
GO

ALTER TABLE [dbo].[CatalogoDiseno] CHECK CONSTRAINT [FK_CatalogoDiseno_Diseno]
GO

ALTER TABLE [dbo].[CatalogoDiseno]  WITH CHECK ADD  CONSTRAINT [FK_CatalogoDiseno_Empleado] FOREIGN KEY([idManicurista])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO

ALTER TABLE [dbo].[CatalogoDiseno] CHECK CONSTRAINT [FK_CatalogoDiseno_Empleado]
GO

ALTER TABLE [dbo].[CatalogoServicio]  WITH CHECK ADD  CONSTRAINT [FK_CatalogoServicio_Empleado] FOREIGN KEY([idManicurista])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO

ALTER TABLE [dbo].[CatalogoServicio] CHECK CONSTRAINT [FK_CatalogoServicio_Empleado]
GO

ALTER TABLE [dbo].[CatalogoServicio]  WITH CHECK ADD  CONSTRAINT [FK_CatalogoServicio_Servicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO

ALTER TABLE [dbo].[CatalogoServicio] CHECK CONSTRAINT [FK_CatalogoServicio_Servicio]
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO

ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Empleado] FOREIGN KEY([idManicurista])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO

ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Empleado]
GO

ALTER TABLE [dbo].[ReservaDedo]  WITH CHECK ADD  CONSTRAINT [FK_ReservaDedo_Dedo] FOREIGN KEY([idDedo])
REFERENCES [dbo].[Dedo] ([idDedo])
GO

ALTER TABLE [dbo].[ReservaDedo] CHECK CONSTRAINT [FK_ReservaDedo_Dedo]
GO

ALTER TABLE [dbo].[ReservaDedo]  WITH CHECK ADD  CONSTRAINT [FK_ReservaDedo_Diseno] FOREIGN KEY([idDiseno])
REFERENCES [dbo].[Diseno] ([idDiseno])
GO

ALTER TABLE [dbo].[ReservaDedo] CHECK CONSTRAINT [FK_ReservaDedo_Diseno]
GO

ALTER TABLE [dbo].[ReservaDedo]  WITH CHECK ADD  CONSTRAINT [FK_ReservaDedo_Reserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([idReserva])
GO

ALTER TABLE [dbo].[ReservaDedo] CHECK CONSTRAINT [FK_ReservaDedo_Reserva]
GO

ALTER TABLE [dbo].[ReservaServicio]  WITH CHECK ADD  CONSTRAINT [FK_ReservaServicio_Reserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([idReserva])
GO

ALTER TABLE [dbo].[ReservaServicio] CHECK CONSTRAINT [FK_ReservaServicio_Reserva]
GO

ALTER TABLE [dbo].[ReservaServicio]  WITH CHECK ADD  CONSTRAINT [FK_ReservaServicio_Servicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO

ALTER TABLE [dbo].[ReservaServicio] CHECK CONSTRAINT [FK_ReservaServicio_Servicio]
GO

ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Empleado] FOREIGN KEY([idManicurista])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO

ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Empleado]
GO

------------------- CREACION DE LLAVES PRIMARIAS COMPUESTAS -------------------

ALTER TABLE [dbo].[CatalogoDiseno] ADD  CONSTRAINT [PK_CatalogoDiseno] PRIMARY KEY CLUSTERED 
(
	[idDiseno] ASC,
	[idManicurista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatalogoServicio] ADD  CONSTRAINT [PK_CatalogoServicio] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC,
	[idManicurista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ReservaDedo] ADD  CONSTRAINT [PK_ReservaDedo] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC,
	[idDedo] ASC,
	[idDiseno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ReservaServicio] ADD  CONSTRAINT [PK_ReservaServicio] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC,
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
