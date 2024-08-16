En este documento encontrarás la correcta configuración de la base de datos para la ejecución del proyecto EmployeeManagement.
Primero debes crear una base de datos en SQL Server con el nombre  EmployeeManagement, no es necesario modificar la collation, se puede dejar la que sale por defecto.
Después de crear la base de datos, se debe ejecutar el script de SQL que se encuentra en la carpeta principal del repositorio con el nombre script.sql.
En este documento se encuentra la creación de la tabla con los campos necesarios.
Igualmente lo dejo en este archivo en la siguiente línea:
USE [EmployeeManagement]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 15/08/2024 09:28:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [name] [varchar](500) NULL,
    [position] [varchar](500) NULL,
    [office] [varchar](500) NULL,
    [salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
    [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

Ya con la base de datos lista, simplemente es necesario clonar el proyecto (Qué está creado y configurado para correr con .NET Framework 4.8 como especificaba el documento), ejecutarlo y eso sería todo.

Igualmente quedo atento a cualquier inquietud.

😃😃😃😃😃


