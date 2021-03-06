USE [master]
GO
/****** Object:  Database [Veterinaria_DB]    Script Date: 3/5/2018 00:25:20 ******/
CREATE DATABASE [Veterinaria_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Veterinaria_DB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Veterinaria_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Veterinaria_DB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Veterinaria_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Veterinaria_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Veterinaria_DB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Veterinaria_DB]
GO
/****** Object:  Table [dbo].[calendario_vac]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calendario_vac](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_vacuna] [int] NOT NULL,
	[fecha_prevista] [date] NOT NULL,
	[fecha_real] [date] NOT NULL,
	[laboratorio] [int] NOT NULL,
	[dosis] [varchar](50) NOT NULL,
	[tipo_doc_empl] [int] NOT NULL,
	[nro_doc_empl] [int] NOT NULL,
 CONSTRAINT [PK_calendario_vac] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_vacuna] ASC,
	[fecha_real] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[consultas]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consultas](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_empl] [int] NOT NULL,
	[nro_doc_empl] [int] NOT NULL,
	[fecha_entrada] [date] NOT NULL,
	[fecha_salida] [date] NULL,
 CONSTRAINT [PK_consultas] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diagnosticos]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnosticos](
	[id_diagnostico] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_diagnosticos] PRIMARY KEY CLUSTERED 
(
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diagnosticoXconsulta]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnosticoXconsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_diagnostico] [int] NOT NULL,
 CONSTRAINT [PK_diagnosticoXconsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dueños]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dueños](
	[id_dueño] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dueños] PRIMARY KEY CLUSTERED 
(
	[id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleados]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[tipo_doc] [int] NOT NULL,
	[nro_doc] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[matricula] [varchar](50) NULL,
	[sucursal] [int] NOT NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[nro_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[laboratorios]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[laboratorios](
	[id_laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](50) NOT NULL,
	[calle] [varchar](50) NOT NULL,
	[numero] [int] NOT NULL,
 CONSTRAINT [PK_laboratorios] PRIMARY KEY CLUSTERED 
(
	[id_laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medicamentos]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicamentos](
	[id_medicamento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[id_laboratorio] [int] NOT NULL,
	[fecha_ultima_compra] [date] NOT NULL,
 CONSTRAINT [PK_medicamentos] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medicamentosXconsulta]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicamentosXconsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_medicamento] [int] NOT NULL,
	[dosis] [varchar](50) NOT NULL,
	[periodicidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_medicamentosXconsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medicamentosXsucursal]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicamentosXsucursal](
	[id_medicamento] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[cantidad_existente] [int] NOT NULL,
	[cantidad_minima] [int] NOT NULL,
 CONSTRAINT [PK_medicamentosXsucursal] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC,
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[perros]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perros](
	[nro_historia_clinica] [int] IDENTITY(1,1) NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[id_raza] [int] NOT NULL,
	[peso] [varchar](50) NOT NULL,
	[altura] [varchar](50) NOT NULL,
	[id_dueño] [int] NOT NULL,
 CONSTRAINT [PK_perros] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[razas]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[razas](
	[id_raza] [int] IDENTITY(1,1) NOT NULL,
	[denominacion] [varchar](50) NOT NULL,
	[peso_minimo_hembra] [varchar](50) NOT NULL,
	[peso_minimo_macho] [varchar](50) NOT NULL,
	[altura_media_hembra] [varchar](50) NOT NULL,
	[altura_media_macho] [varchar](50) NOT NULL,
	[nota_cuidados] [varchar](200) NOT NULL,
 CONSTRAINT [PK_razas] PRIMARY KEY CLUSTERED 
(
	[id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sintomas]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sintomas](
	[id_sintoma] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_sintomas] PRIMARY KEY CLUSTERED 
(
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sintomasXconsulta]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sintomasXconsulta](
	[nro_historia_clinica] [int] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_sintoma] [int] NOT NULL,
 CONSTRAINT [PK_sintomasXconsulta] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_sucursal] ASC,
	[id_consulta] ASC,
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sucursales]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursales](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tipo_doc_superv] [int] NOT NULL,
	[nro_doc_superv] [int] NOT NULL,
	[tipo_doc_super_supl] [int] NOT NULL,
	[nro_doc_super_supl] [int] NOT NULL,
 CONSTRAINT [PK_sucursales] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipos_doc]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos_doc](
	[id_tipo_doc] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_doc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipos_doc] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vacunas]    Script Date: 3/5/2018 00:25:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacunas](
	[id_vacuna] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vacunas] PRIMARY KEY CLUSTERED 
(
	[id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[diagnosticos] ON 

INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (1, N'Envenenamiento')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (2, N'Picadura de insectos')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (3, N'Parásitos')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (4, N'Rabia')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (5, N'Coronavirus')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (6, N'Hepatitis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (7, N'Moquillo')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (8, N'Parvovirus')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (9, N'Displacia de cadera')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (10, N'Artosis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (11, N'Epilepsia')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (12, N'Demencia senil')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (13, N'Meningitis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (14, N'Leptospirosis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (15, N'Periodontitis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (16, N'Cistitis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (17, N'Cáncer')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (18, N'Diabetes')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (19, N'Leishmaniosis')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (20, N'Garrapatas')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (21, N'Sarna')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (22, N'Reumatismo')
INSERT [dbo].[diagnosticos] ([id_diagnostico], [descripcion]) VALUES (23, N'Glaucoma')
SET IDENTITY_INSERT [dbo].[diagnosticos] OFF
SET IDENTITY_INSERT [dbo].[dueños] ON 

INSERT [dbo].[dueños] ([id_dueño], [nombre], [apellido], [telefono]) VALUES (1, N'Ricardo', N'Nuñez', N'0351-4842460')
INSERT [dbo].[dueños] ([id_dueño], [nombre], [apellido], [telefono]) VALUES (2, N'Norman', N'Ramallo', N'0351-4842321')
INSERT [dbo].[dueños] ([id_dueño], [nombre], [apellido], [telefono]) VALUES (3, N'Melisa', N'Galarza', N'0351-5328511')
INSERT [dbo].[dueños] ([id_dueño], [nombre], [apellido], [telefono]) VALUES (4, N'Melani', N'Ramallo', N'0351-5632217')
INSERT [dbo].[dueños] ([id_dueño], [nombre], [apellido], [telefono]) VALUES (5, N'Nicolas', N'Sanchez', N'011-12583120')
SET IDENTITY_INSERT [dbo].[dueños] OFF
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 29615003, N'Luciano', N'Ponce', CAST(N'1980-11-23' AS Date), CAST(N'2000-07-12' AS Date), N'Médico Veterinario', 2)
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 31057851, N'Daniela', N'Gutierrez', CAST(N'1984-09-15' AS Date), CAST(N'2008-05-20' AS Date), N'Médico Veterinario', 1)
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 34715341, N'Matias ', N'Maldonado', CAST(N'1990-01-28' AS Date), CAST(N'2016-08-04' AS Date), N'Técnico Veterinario', 1)
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 37860140, N'Francisco', N'Diaz', CAST(N'1992-05-12' AS Date), CAST(N'2017-09-11' AS Date), N'Técnico Veterinario', 2)
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 39648900, N'Martina', N'Cordoba', CAST(N'1996-05-09' AS Date), CAST(N'2018-12-01' AS Date), NULL, 2)
INSERT [dbo].[empleados] ([tipo_doc], [nro_doc], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [sucursal]) VALUES (1, 40106395, N'Melani', N'Ramallo', CAST(N'1997-03-14' AS Date), CAST(N'2018-04-25' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[laboratorios] ON 

INSERT [dbo].[laboratorios] ([id_laboratorio], [razon_social], [calle], [numero]) VALUES (1, N'Laboratorios Vet S.A', N'Avenida Colon', 2900)
INSERT [dbo].[laboratorios] ([id_laboratorio], [razon_social], [calle], [numero]) VALUES (2, N'Laboratorios Can S.A', N'Rafael Nuñez', 1500)
INSERT [dbo].[laboratorios] ([id_laboratorio], [razon_social], [calle], [numero]) VALUES (3, N'Lab Social S.A', N'Figueroa Alcorta', 800)
SET IDENTITY_INSERT [dbo].[laboratorios] OFF
SET IDENTITY_INSERT [dbo].[medicamentos] ON 

INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (1, N'Solución Oftálmica Antibacteriano Sin Esteroides ', 1, CAST(N'2018-03-21' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (2, N'Antibacterial Perro con Esteroides', 2, CAST(N'2018-04-13' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (3, N'Analgésico Canidryl 100 MG 140 comprimidos', 1, CAST(N'2018-03-21' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (4, N'Analgésico Carprodyl 20 MG 1 comprimido', 1, CAST(N'2018-03-21' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (5, N'Digestivo CERENIA 20 ml Inyectable', 2, CAST(N'2018-04-13' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (6, N'Oncológico APOPTUS 60 comprimidos', 2, CAST(N'2018-04-13' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (7, N'Inmunològico IMPROMUNE 20 comprimidos', 1, CAST(N'2018-05-01' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (8, N'Antiparasitario Interno CANITENOL PLUS 100 comprimidos', 2, CAST(N'2018-05-01' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (9, N'Antiparasitario ACTIVYL PLUS 150 480 MG 5-10 kg', 2, CAST(N'2018-05-01' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (10, N'Bucodental CLUNICAL ZNA', 1, CAST(N'2018-05-01' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (11, N'Tranquilizante ACEPROVET 20 ml', 1, CAST(N'2018-04-25' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (12, N'Suero DEXTRANORM SALINO 500 ml', 1, CAST(N'2018-04-25' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (13, N'Antidepresivo CLOMICALM 20 mg 30 comprimidos', 2, CAST(N'2018-04-12' AS Date))
INSERT [dbo].[medicamentos] ([id_medicamento], [descripcion], [id_laboratorio], [fecha_ultima_compra]) VALUES (14, N'Antidepresivo CLOMICALM 5 mg 30 comprimidos', 2, CAST(N'2018-04-12' AS Date))
SET IDENTITY_INSERT [dbo].[medicamentos] OFF
SET IDENTITY_INSERT [dbo].[perros] ON 

INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (1, 1, N'Roco', CAST(N'2003-12-08' AS Date), 7, N'7,200 kg', N'20 cm', 4)
INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (2, 1, N'Teo', CAST(N'2009-12-25' AS Date), 7, N'7,250 kg', N'21 cm', 4)
INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (3, 2, N'Spunky', CAST(N'2003-02-15' AS Date), 3, N'15 kg', N'35 cm', 1)
INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (4, 2, N'Toto', CAST(N'2018-03-19' AS Date), 1, N'32,100 kg', N'63 cm', 3)
INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (5, 1, N'Sami', CAST(N'2010-09-04' AS Date), 4, N'45 kg', N'69 cm', 5)
INSERT [dbo].[perros] ([nro_historia_clinica], [id_sucursal], [nombre], [fecha_nacimiento], [id_raza], [peso], [altura], [id_dueño]) VALUES (6, 2, N'Lola', CAST(N'2015-07-14' AS Date), 6, N'46 kg', N'77 cm', 2)
SET IDENTITY_INSERT [dbo].[perros] OFF
SET IDENTITY_INSERT [dbo].[razas] ON 

INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (1, N'Pastor alemán', N'22 kg', N'30 kg', N'57,5 cm', N'62,5 cm', N'Necesita practicar ejercicio de modo continuo ya que es una raza de trabajo, se debe evitar la sobrealimentación ya que posee un apetito voraz que lo puede llevar a padecer problemas gástricos ')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (2, N'Golden retriever', N'25 kg', N'30 kg', N'53,5 cm', N'58,5 cm', N'Se le debe proporcionar tanto una adecuada socialización temprana, como una actividad fisíca diaria para evitar conductas destructivas')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (3, N'Caniche', N'12 kg', N'12 kg', N'37,5 cm', N'37,5 cm', N'Necesita compañia, por lo que no es conveniente dejarlos solor mucho tiempo')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (4, N'Dóberman ', N'32 kg', N'40 kg', N'64,5 cm', N'69 cm', N'Ejercicio diario y brindarle espacio cálido para dormir ya que no soporta bajas temperaturas')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (6, N'Gran danés', N'45 kg', N'54 kg', N'76 cm', N'81 cm', N'Es necesario que camine diariamente sin esfuerzos o cambios bruscos de temperatura')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (7, N'Dachshund', N'7 kg', N'7 kg', N'20 cm', N'20 cm', N'Evitar los saltos, el sobrepeso y subir y bajar escaleras con frecuencia')
INSERT [dbo].[razas] ([id_raza], [denominacion], [peso_minimo_hembra], [peso_minimo_macho], [altura_media_hembra], [altura_media_macho], [nota_cuidados]) VALUES (9, N'Pit Bull', N'14 kg', N'15 kg', N'40 cm', N'43 cm', N'Brindale ejercicio físico y metal para que descargue su energía')
SET IDENTITY_INSERT [dbo].[razas] OFF
SET IDENTITY_INSERT [dbo].[sintomas] ON 

INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (1, N'Fiebre')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (2, N'Letargo')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (3, N'Adelgazamiento')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (4, N'Dolor')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (5, N'Inflamación')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (6, N'Cojera')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (7, N'Hiperactividad')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (8, N'Lloriqueos')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (9, N'Sangre en orina')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (10, N'Diarrea')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (11, N'Sed extrema')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (12, N'Cataratas')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (13, N'Micciones frecuentes')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (14, N'Aumento de apetito')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (15, N'Sarro y/o placa')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (16, N'Vómitos con sangre')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (17, N'Orina Oscura')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (18, N'Descoordinación')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (19, N'Desorientación')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (20, N'Trastornos del sueño')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (21, N'Agotamiento')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (22, N'Temblores')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (23, N'Nerviosismo')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (24, N'Saliva en exceso')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (25, N'Vómitos')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (26, N'Convulciones')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (27, N'Pérdida de consciencia')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (28, N'Rigidez')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (29, N'Espuma blanca')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (30, N'Depresión')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (31, N'Deshidratación')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (32, N'Sarpullido')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (33, N'Anemia')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (34, N'Gusanos')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (35, N'Secreción nasal')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (36, N'Violencia extrema')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (37, N'Quebradura')
INSERT [dbo].[sintomas] ([id_sintoma], [descripcion]) VALUES (38, N'Líquido en el ojo')
SET IDENTITY_INSERT [dbo].[sintomas] OFF
SET IDENTITY_INSERT [dbo].[sucursales] ON 

INSERT [dbo].[sucursales] ([id_sucursal], [nombre], [tipo_doc_superv], [nro_doc_superv], [tipo_doc_super_supl], [nro_doc_super_supl]) VALUES (1, N'Hocicos', 1, 31057851, 1, 34715341)
INSERT [dbo].[sucursales] ([id_sucursal], [nombre], [tipo_doc_superv], [nro_doc_superv], [tipo_doc_super_supl], [nro_doc_super_supl]) VALUES (2, N'Patitas de Perro', 1, 29615003, 1, 37860140)
SET IDENTITY_INSERT [dbo].[sucursales] OFF
SET IDENTITY_INSERT [dbo].[tipos_doc] ON 

INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (1, N'DNI')
INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (2, N'LE')
INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (3, N'LC')
INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (4, N'CEDULA')
INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (5, N'PASAPORTE')
INSERT [dbo].[tipos_doc] ([id_tipo_doc], [nombre_tipo_doc]) VALUES (6, N'S/D')
SET IDENTITY_INSERT [dbo].[tipos_doc] OFF
SET IDENTITY_INSERT [dbo].[vacunas] ON 

INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (1, N'Parvovirus')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (2, N'Moquillo')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (3, N'Adenovirus tipo 2 ')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (4, N'Hepatitis infecciosa C ')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (5, N'Leptospirosis')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (6, N'Coronavirus')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (7, N'Rabia')
INSERT [dbo].[vacunas] ([id_vacuna], [descripcion]) VALUES (8, N'Parainfluenza')
SET IDENTITY_INSERT [dbo].[vacunas] OFF
ALTER TABLE [dbo].[calendario_vac]  WITH CHECK ADD  CONSTRAINT [FK_calendario_vac_empleados] FOREIGN KEY([tipo_doc_empl], [nro_doc_empl])
REFERENCES [dbo].[empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[calendario_vac] CHECK CONSTRAINT [FK_calendario_vac_empleados]
GO
ALTER TABLE [dbo].[calendario_vac]  WITH CHECK ADD  CONSTRAINT [FK_calendario_vac_laboratorios] FOREIGN KEY([laboratorio])
REFERENCES [dbo].[laboratorios] ([id_laboratorio])
GO
ALTER TABLE [dbo].[calendario_vac] CHECK CONSTRAINT [FK_calendario_vac_laboratorios]
GO
ALTER TABLE [dbo].[calendario_vac]  WITH CHECK ADD  CONSTRAINT [FK_calendario_vac_perros] FOREIGN KEY([nro_historia_clinica], [id_sucursal])
REFERENCES [dbo].[perros] ([nro_historia_clinica], [id_sucursal])
GO
ALTER TABLE [dbo].[calendario_vac] CHECK CONSTRAINT [FK_calendario_vac_perros]
GO
ALTER TABLE [dbo].[calendario_vac]  WITH CHECK ADD  CONSTRAINT [FK_calendario_vac_tipos_doc] FOREIGN KEY([tipo_doc_empl])
REFERENCES [dbo].[tipos_doc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[calendario_vac] CHECK CONSTRAINT [FK_calendario_vac_tipos_doc]
GO
ALTER TABLE [dbo].[calendario_vac]  WITH CHECK ADD  CONSTRAINT [FK_calendario_vac_vacunas] FOREIGN KEY([id_vacuna])
REFERENCES [dbo].[vacunas] ([id_vacuna])
GO
ALTER TABLE [dbo].[calendario_vac] CHECK CONSTRAINT [FK_calendario_vac_vacunas]
GO
ALTER TABLE [dbo].[consultas]  WITH CHECK ADD  CONSTRAINT [FK_consultas_empleados] FOREIGN KEY([tipo_doc_empl], [nro_doc_empl])
REFERENCES [dbo].[empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[consultas] CHECK CONSTRAINT [FK_consultas_empleados]
GO
ALTER TABLE [dbo].[consultas]  WITH CHECK ADD  CONSTRAINT [FK_consultas_perros] FOREIGN KEY([nro_historia_clinica], [id_sucursal])
REFERENCES [dbo].[perros] ([nro_historia_clinica], [id_sucursal])
GO
ALTER TABLE [dbo].[consultas] CHECK CONSTRAINT [FK_consultas_perros]
GO
ALTER TABLE [dbo].[consultas]  WITH CHECK ADD  CONSTRAINT [FK_consultas_tipos_doc] FOREIGN KEY([tipo_doc_empl])
REFERENCES [dbo].[tipos_doc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[consultas] CHECK CONSTRAINT [FK_consultas_tipos_doc]
GO
ALTER TABLE [dbo].[diagnosticoXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_diagnosticoXconsulta_consultas] FOREIGN KEY([nro_historia_clinica], [id_sucursal], [id_consulta])
REFERENCES [dbo].[consultas] ([nro_historia_clinica], [id_sucursal], [id_consulta])
GO
ALTER TABLE [dbo].[diagnosticoXconsulta] CHECK CONSTRAINT [FK_diagnosticoXconsulta_consultas]
GO
ALTER TABLE [dbo].[diagnosticoXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_diagnosticoXconsulta_diagnosticos] FOREIGN KEY([id_diagnostico])
REFERENCES [dbo].[diagnosticos] ([id_diagnostico])
GO
ALTER TABLE [dbo].[diagnosticoXconsulta] CHECK CONSTRAINT [FK_diagnosticoXconsulta_diagnosticos]
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_empleados_sucursales] FOREIGN KEY([sucursal])
REFERENCES [dbo].[sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [FK_empleados_sucursales]
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_empleados_tipos_doc] FOREIGN KEY([tipo_doc])
REFERENCES [dbo].[tipos_doc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [FK_empleados_tipos_doc]
GO
ALTER TABLE [dbo].[medicamentos]  WITH CHECK ADD  CONSTRAINT [FK_medicamentos_laboratorios] FOREIGN KEY([id_laboratorio])
REFERENCES [dbo].[laboratorios] ([id_laboratorio])
GO
ALTER TABLE [dbo].[medicamentos] CHECK CONSTRAINT [FK_medicamentos_laboratorios]
GO
ALTER TABLE [dbo].[medicamentosXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_medicamentosXconsulta_consultas] FOREIGN KEY([nro_historia_clinica], [id_sucursal], [id_consulta])
REFERENCES [dbo].[consultas] ([nro_historia_clinica], [id_sucursal], [id_consulta])
GO
ALTER TABLE [dbo].[medicamentosXconsulta] CHECK CONSTRAINT [FK_medicamentosXconsulta_consultas]
GO
ALTER TABLE [dbo].[medicamentosXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_medicamentosXconsulta_medicamentos] FOREIGN KEY([id_medicamento])
REFERENCES [dbo].[medicamentos] ([id_medicamento])
GO
ALTER TABLE [dbo].[medicamentosXconsulta] CHECK CONSTRAINT [FK_medicamentosXconsulta_medicamentos]
GO
ALTER TABLE [dbo].[medicamentosXsucursal]  WITH CHECK ADD  CONSTRAINT [FK_medicamentosXsucursal_medicamentos] FOREIGN KEY([id_medicamento])
REFERENCES [dbo].[medicamentos] ([id_medicamento])
GO
ALTER TABLE [dbo].[medicamentosXsucursal] CHECK CONSTRAINT [FK_medicamentosXsucursal_medicamentos]
GO
ALTER TABLE [dbo].[medicamentosXsucursal]  WITH CHECK ADD  CONSTRAINT [FK_medicamentosXsucursal_sucursales] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[medicamentosXsucursal] CHECK CONSTRAINT [FK_medicamentosXsucursal_sucursales]
GO
ALTER TABLE [dbo].[perros]  WITH CHECK ADD  CONSTRAINT [FK_perros_dueños] FOREIGN KEY([id_dueño])
REFERENCES [dbo].[dueños] ([id_dueño])
GO
ALTER TABLE [dbo].[perros] CHECK CONSTRAINT [FK_perros_dueños]
GO
ALTER TABLE [dbo].[perros]  WITH CHECK ADD  CONSTRAINT [FK_perros_razas] FOREIGN KEY([id_raza])
REFERENCES [dbo].[razas] ([id_raza])
GO
ALTER TABLE [dbo].[perros] CHECK CONSTRAINT [FK_perros_razas]
GO
ALTER TABLE [dbo].[perros]  WITH CHECK ADD  CONSTRAINT [FK_perros_sucursales] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[sucursales] ([id_sucursal])
GO
ALTER TABLE [dbo].[perros] CHECK CONSTRAINT [FK_perros_sucursales]
GO
ALTER TABLE [dbo].[sintomasXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_sintomasXconsulta_consultas] FOREIGN KEY([nro_historia_clinica], [id_sucursal], [id_consulta])
REFERENCES [dbo].[consultas] ([nro_historia_clinica], [id_sucursal], [id_consulta])
GO
ALTER TABLE [dbo].[sintomasXconsulta] CHECK CONSTRAINT [FK_sintomasXconsulta_consultas]
GO
ALTER TABLE [dbo].[sintomasXconsulta]  WITH CHECK ADD  CONSTRAINT [FK_sintomasXconsulta_sintomas] FOREIGN KEY([id_sintoma])
REFERENCES [dbo].[sintomas] ([id_sintoma])
GO
ALTER TABLE [dbo].[sintomasXconsulta] CHECK CONSTRAINT [FK_sintomasXconsulta_sintomas]
GO
ALTER TABLE [dbo].[sucursales]  WITH CHECK ADD  CONSTRAINT [FK_sucursales_empleados] FOREIGN KEY([tipo_doc_superv], [nro_doc_superv])
REFERENCES [dbo].[empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[sucursales] CHECK CONSTRAINT [FK_sucursales_empleados]
GO
ALTER TABLE [dbo].[sucursales]  WITH CHECK ADD  CONSTRAINT [FK_sucursales_empleados1] FOREIGN KEY([tipo_doc_super_supl], [nro_doc_super_supl])
REFERENCES [dbo].[empleados] ([tipo_doc], [nro_doc])
GO
ALTER TABLE [dbo].[sucursales] CHECK CONSTRAINT [FK_sucursales_empleados1]
GO
ALTER TABLE [dbo].[sucursales]  WITH CHECK ADD  CONSTRAINT [FK_sucursales_tipos_doc] FOREIGN KEY([tipo_doc_superv])
REFERENCES [dbo].[tipos_doc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[sucursales] CHECK CONSTRAINT [FK_sucursales_tipos_doc]
GO
ALTER TABLE [dbo].[sucursales]  WITH CHECK ADD  CONSTRAINT [FK_sucursales_tipos_doc1] FOREIGN KEY([tipo_doc_super_supl])
REFERENCES [dbo].[tipos_doc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[sucursales] CHECK CONSTRAINT [FK_sucursales_tipos_doc1]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria_DB] SET  READ_WRITE 
GO
