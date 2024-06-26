USE [MGsoft]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[idBitacora] [int] NOT NULL,
	[Incidencia] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NOT NULL,
	[Fecha] [date] NOT NULL,
	[FKidTrabajoBit] [int] NULL,
 CONSTRAINT [PK_Bitacora de incidencias] PRIMARY KEY CLUSTERED 
(
	[idBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] NOT NULL,
	[nomCliente] [nvarchar](max) NOT NULL,
	[Domicilio] [nvarchar](50) NULL,
	[Telefono] [nchar](10) NOT NULL,
	[Fecha] [date] NULL,
	[FKidTrabajo] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] NOT NULL,
	[nomEmpleado] [nvarchar](max) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Telefono] [nchar](10) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[EstadoEmpleado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[idUsuario] [int] NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajo]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajo](
	[idTrabajo] [int] NOT NULL,
	[trabajo] [nvarchar](max) NOT NULL,
	[AreaTrabajo] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[EstadoTrabajo] [nvarchar](50) NOT NULL,
	[FKidCliente] [int] NULL,
	[Cliente] [nvarchar](50) NULL,
	[Empleado] [nvarchar](50) NULL,
 CONSTRAINT [PK_Trabajo] PRIMARY KEY CLUSTERED 
(
	[idTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrabajoEmpleado]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrabajoEmpleado](
	[idEmpTrab] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[id_Trabajo] [int] NOT NULL,
 CONSTRAINT [PK_TrabajoEmpleado] PRIMARY KEY CLUSTERED 
(
	[idEmpTrab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Trabajo1] FOREIGN KEY([FKidTrabajoBit])
REFERENCES [dbo].[Trabajo] ([idTrabajo])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Trabajo1]
GO
ALTER TABLE [dbo].[Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Trabajo_Clientes] FOREIGN KEY([FKidCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Trabajo] CHECK CONSTRAINT [FK_Trabajo_Clientes]
GO
ALTER TABLE [dbo].[TrabajoEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoEmpleado_Trabajo] FOREIGN KEY([id_Trabajo])
REFERENCES [dbo].[Trabajo] ([idTrabajo])
GO
ALTER TABLE [dbo].[TrabajoEmpleado] CHECK CONSTRAINT [FK_TrabajoEmpleado_Trabajo]
GO
ALTER TABLE [dbo].[TrabajoEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoIDEmpleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[TrabajoEmpleado] CHECK CONSTRAINT [FK_TrabajoIDEmpleado]
GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleados]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InsertarEmpleados]
    @idem INT,
    @ne NVARCHAR(100),
    @dmc NVARCHAR(100),
    @tel Nchar(10),
	@cor NVARCHAR (40),
	@Esem NVARCHAR (40)

AS
BEGIN
    INSERT INTO Empleado (idEmpleado, nomEmpleado, Domicilio, Telefono, Correo, EstadoEmpleado)
    VALUES (@idem, @ne, @dmc, @tel, @cor, @Esem)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarTrabajo]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarTrabajo]
    @idTr INT,
    @trab NVARCHAR(100),
    @ArTr NVARCHAR(100),
    @fch DATETIME,
    @EsTr NVARCHAR(50),
    @nomEmp NVARCHAR(100),
    @nomCl NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON; -- Evita la impresión de los mensajes "n filas afectadas"

    -- Insertar los valores proporcionados en la tabla Trabajo
    INSERT INTO Trabajo (idTrabajo, trabajo, AreaTrabajo, Fecha, EstadoTrabajo, Empleado, Cliente)
    VALUES (@idTr, @trab, @ArTr, @fch, @EsTr, @nomEmp, @nomCl);
END
GO
/****** Object:  StoredProcedure [dbo].[InsetarProductos]    Script Date: 18/04/2024 11:43:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsetarProductos]
    @idc INT,
	@nc NVARCHAR(100),
    @dmc NVARCHAR(100),
    @tel Nchar(10),
	@fch Date

	
AS
BEGIN
    INSERT INTO Clientes (idCliente, nomCliente, Domicilio, Telefono, Fecha)
    VALUES (@idc, @nc, @dmc, @tel, @fch)
END
GO
