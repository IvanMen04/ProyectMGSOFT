USE [MGsoft]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
/****** Object:  Table [dbo].[Login]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
/****** Object:  Table [dbo].[Trabajo]    Script Date: 03/04/2024 08:23:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajo](
	[idTrabajo] [int] NOT NULL,
	[Trabajo] [nvarchar](max) NOT NULL,
	[AreaTrabajo] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[EstadoTrabajo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Trabajo] PRIMARY KEY CLUSTERED 
(
	[idTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrabajoEmpleado]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Trabajo] FOREIGN KEY([FKidTrabajoBit])
REFERENCES [dbo].[Trabajo] ([idTrabajo])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Trabajo]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Trabajo] FOREIGN KEY([FKidTrabajo])
REFERENCES [dbo].[Trabajo] ([idTrabajo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Trabajo]
GO
ALTER TABLE [dbo].[TrabajoEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoEmpleado] FOREIGN KEY([id_Trabajo])
REFERENCES [dbo].[Trabajo] ([idTrabajo])
GO
ALTER TABLE [dbo].[TrabajoEmpleado] CHECK CONSTRAINT [FK_TrabajoEmpleado]
GO
ALTER TABLE [dbo].[TrabajoEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoIDEmpleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[TrabajoEmpleado] CHECK CONSTRAINT [FK_TrabajoIDEmpleado]
GO
/****** Object:  StoredProcedure [dbo].[InsetarProductos]    Script Date: 03/04/2024 08:23:36 p. m. ******/
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
