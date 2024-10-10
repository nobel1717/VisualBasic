USE [master]
GO
/****** Object:  Database [Asig8des8]    Script Date: 09/10/2024 09:55:16 p. m. ******/
CREATE DATABASE [Asig8des8]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Asig8des8', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Asig8des8.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Asig8des8_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Asig8des8_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Asig8des8] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Asig8des8].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Asig8des8] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Asig8des8] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Asig8des8] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Asig8des8] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Asig8des8] SET ARITHABORT OFF 
GO
ALTER DATABASE [Asig8des8] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Asig8des8] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Asig8des8] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Asig8des8] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Asig8des8] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Asig8des8] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Asig8des8] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Asig8des8] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Asig8des8] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Asig8des8] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Asig8des8] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Asig8des8] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Asig8des8] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Asig8des8] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Asig8des8] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Asig8des8] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Asig8des8] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Asig8des8] SET RECOVERY FULL 
GO
ALTER DATABASE [Asig8des8] SET  MULTI_USER 
GO
ALTER DATABASE [Asig8des8] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Asig8des8] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Asig8des8] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Asig8des8] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Asig8des8] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Asig8des8] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Asig8des8', N'ON'
GO
ALTER DATABASE [Asig8des8] SET QUERY_STORE = OFF
GO
USE [Asig8des8]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 09/10/2024 09:55:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Cedula] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Edad] [int] NULL,
	[Correo] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Cedula], [Nombre], [Apellido], [Edad], [Correo]) VALUES (N'8-343-545', N'Juliano', N'Fargan', 23, N'Juliifa@gmail.com')
GO
INSERT [dbo].[Clientes] ([Cedula], [Nombre], [Apellido], [Edad], [Correo]) VALUES (N'8-345-875', N'Edilberto', N'Martinez', 43, N'edilbertomm@gmail.com')
GO
/****** Object:  StoredProcedure [dbo].[ActualizarRegistro]    Script Date: 09/10/2024 09:55:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarRegistro]
    @Cedula NVARCHAR(50),  -- Cambiado de INT a NVARCHAR(50)
    @Nombre NVARCHAR(50),
    @Apellido NVARCHAR(50),
    @Edad INT,
    @Correo NVARCHAR(100)
AS
BEGIN
    UPDATE Clientes
    SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Correo = @Correo
    WHERE Cedula = @Cedula
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarRegistro]    Script Date: 09/10/2024 09:55:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ConsultarRegistro]
    @Cedula NVARCHAR(50)  -- Cambiado de INT a NVARCHAR(50)
AS
BEGIN
    SELECT Nombre, Apellido, Edad, Correo
    FROM Clientes  -- Cambié de MiTabla a Clientes
    WHERE Cedula = @Cedula
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarRegistro]    Script Date: 09/10/2024 09:55:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarRegistro]
    @Cedula NVARCHAR(50)  -- Cambiado de INT a NVARCHAR(50)
AS
BEGIN
    DELETE FROM Clientes
    WHERE Cedula = @Cedula
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarRegistro]    Script Date: 09/10/2024 09:55:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarRegistro]
    @Cedula NVARCHAR(50),  -- Cambiado de INT a NVARCHAR(50)
    @Nombre NVARCHAR(50),
    @Apellido NVARCHAR(50),
    @Edad INT,
    @Correo NVARCHAR(100)
AS
BEGIN
    INSERT INTO Clientes (Cedula, Nombre, Apellido, Edad, Correo)
    VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Correo)
END
GO
USE [master]
GO
ALTER DATABASE [Asig8des8] SET  READ_WRITE 
GO
