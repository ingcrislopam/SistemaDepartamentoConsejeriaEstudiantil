USE [master]
GO
/****** Object:  Database [SistemaColegioTecnico]    Script Date: 04/16/2015 12:17:29 ******/
CREATE DATABASE [SistemaColegioTecnico] ON  PRIMARY 
( NAME = N'SistemaColegioTecnico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.FACCI\MSSQL\DATA\SistemaColegioTecnico.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaColegioTecnico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.FACCI\MSSQL\DATA\SistemaColegioTecnico_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaColegioTecnico] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaColegioTecnico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaColegioTecnico] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET ARITHABORT OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SistemaColegioTecnico] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SistemaColegioTecnico] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SistemaColegioTecnico] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET  DISABLE_BROKER
GO
ALTER DATABASE [SistemaColegioTecnico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SistemaColegioTecnico] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SistemaColegioTecnico] SET  READ_WRITE
GO
ALTER DATABASE [SistemaColegioTecnico] SET RECOVERY FULL
GO
ALTER DATABASE [SistemaColegioTecnico] SET  MULTI_USER
GO
ALTER DATABASE [SistemaColegioTecnico] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SistemaColegioTecnico] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaColegioTecnico', N'ON'
GO
USE [SistemaColegioTecnico]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaRegistro] [varchar](50) NULL,
	[cedula] [varchar](10) NOT NULL,
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[curso] [int] NULL,
	[paralelo] [varchar](1) NULL,
	[especialidad] [varchar](50) NULL,
	[edad] [int] NULL,
	[sexo] [varchar](50) NULL,
	[bytesFoto] [varchar](max) NULL,
	[seccion] [varchar](50) NULL,
	[lugarNacimiento] [varchar](50) NULL,
	[centroEducativoProviene] [varchar](50) NULL,
	[correoElectronico] [varchar](50) NULL,
 CONSTRAINT [PK_estudiantes_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[representantes]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[representantes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[estudiante] [varchar](100) NULL,
	[cedulaRepresentante] [varchar](50) NULL,
	[nombresRepresentante] [varchar](50) NULL,
	[apellidosRepresentante] [varchar](50) NULL,
	[parentescoAlumno] [varchar](50) NULL,
	[sexo] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[lugarNacimiento] [varchar](50) NULL,
	[estadoCivil] [varchar](50) NULL,
	[bytesFoto] [varchar](max) NULL,
	[direccionDomiciliaria] [varchar](50) NULL,
	[ocupacion] [varchar](50) NULL,
	[lugarTrabajo] [varchar](50) NULL,
	[cargo] [varchar](50) NULL,
	[correoElectronico] [varchar](50) NULL,
	[statusCorreo] [varchar](50) NULL,
 CONSTRAINT [PK_representantes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[historialesFormativos]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[historialesFormativos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[trabajoIndependiente] [float] NULL,
	[actividadesIndividuales] [float] NULL,
	[actividadesGrupales] [float] NULL,
	[lecciones] [float] NULL,
	[evaluacionSumativa] [float] NULL,
 CONSTRAINT [PK_historialesFormativos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[historialesComportamentales]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[historialesComportamentales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[respetoEstudiantes] [varchar](50) NULL,
	[calificacionRespeto] [int] NULL,
	[destrezasComunicacionales] [varchar](50) NULL,
	[calificacionDestrezas] [int] NULL,
	[desafioIntelectual] [varchar](50) NULL,
	[calificacionDesafio] [int] NULL,
	[cumplimientoCompromisos] [varchar](50) NULL,
	[calificacionCumplimiento] [int] NULL,
	[puntualidad] [varchar](50) NULL,
	[calificacionPuntualidad] [int] NULL,
	[asistencia] [varchar](50) NULL,
	[calificacionAsistencia] [int] NULL,
	[limpieza] [varchar](50) NULL,
	[calificacionLimpieza] [int] NULL,
 CONSTRAINT [PK_historialesComportamentales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estudiantesRepresentantes]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantesRepresentantes](
	[idEstudiantes] [int] NULL,
	[idRepresentantes] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[antecedentesPersonales]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[antecedentesPersonales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[fechaNacimiento] [varchar](50) NULL,
	[residencia] [varchar](50) NULL,
	[religion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[ocupacion] [varchar](50) NULL,
	[numeroHermanos] [int] NULL,
	[motivosVisitaDepartamento] [varchar](50) NULL,
 CONSTRAINT [PK_antecedentesPersonales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[antecedentesFamiliares]    Script Date: 04/16/2015 12:17:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[antecedentesFamiliares](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idEstudiante] [int] NULL,
	[fecha] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[hogarCompleto] [varchar](50) NULL,
	[hogarDisfuncional] [varchar](50) NULL,
	[violenciaIntrafamiliar] [varchar](50) NULL,
	[tipoViolencia] [varchar](50) NULL,
	[farmaco] [varchar](50) NULL,
	[tipoFarmaco] [varchar](50) NULL,
	[enfermedad] [varchar](50) NULL,
	[tipoEnfermedad] [varchar](50) NULL,
	[diagnosticoPresuntivo] [varchar](50) NULL,
	[diagnosticoDefinitivo] [varchar](50) NULL,
	[recomendaciones] [varchar](200) NULL,
 CONSTRAINT [PK_antecedentesFamiliares] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_historialesFormativos_estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[historialesFormativos]  WITH CHECK ADD  CONSTRAINT [FK_historialesFormativos_estudiantes] FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[estudiantes] ([id])
GO
ALTER TABLE [dbo].[historialesFormativos] CHECK CONSTRAINT [FK_historialesFormativos_estudiantes]
GO
/****** Object:  ForeignKey [FK_historialesComportamentales_estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[historialesComportamentales]  WITH CHECK ADD  CONSTRAINT [FK_historialesComportamentales_estudiantes] FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[estudiantes] ([id])
GO
ALTER TABLE [dbo].[historialesComportamentales] CHECK CONSTRAINT [FK_historialesComportamentales_estudiantes]
GO
/****** Object:  ForeignKey [FK_estudiantesRepresentantes_estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[estudiantesRepresentantes]  WITH CHECK ADD  CONSTRAINT [FK_estudiantesRepresentantes_estudiantes] FOREIGN KEY([idEstudiantes])
REFERENCES [dbo].[estudiantes] ([id])
GO
ALTER TABLE [dbo].[estudiantesRepresentantes] CHECK CONSTRAINT [FK_estudiantesRepresentantes_estudiantes]
GO
/****** Object:  ForeignKey [FK_estudiantesRepresentantes_representantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[estudiantesRepresentantes]  WITH CHECK ADD  CONSTRAINT [FK_estudiantesRepresentantes_representantes] FOREIGN KEY([idRepresentantes])
REFERENCES [dbo].[representantes] ([id])
GO
ALTER TABLE [dbo].[estudiantesRepresentantes] CHECK CONSTRAINT [FK_estudiantesRepresentantes_representantes]
GO
/****** Object:  ForeignKey [FK_antecedentesPersonales_estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[antecedentesPersonales]  WITH CHECK ADD  CONSTRAINT [FK_antecedentesPersonales_estudiantes] FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[estudiantes] ([id])
GO
ALTER TABLE [dbo].[antecedentesPersonales] CHECK CONSTRAINT [FK_antecedentesPersonales_estudiantes]
GO
/****** Object:  ForeignKey [FK_antecedentesFamiliares_estudiantes]    Script Date: 04/16/2015 12:17:30 ******/
ALTER TABLE [dbo].[antecedentesFamiliares]  WITH CHECK ADD  CONSTRAINT [FK_antecedentesFamiliares_estudiantes] FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[estudiantes] ([id])
GO
ALTER TABLE [dbo].[antecedentesFamiliares] CHECK CONSTRAINT [FK_antecedentesFamiliares_estudiantes]
GO
