-- Crear la base de datos
CREATE DATABASE BibliotecaDB;

-- Usar la base de datos
USE BibliotecaDB;

-- Tabla Libros
CREATE TABLE Libros 
(
    LibroID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único para cada libro
    Titulo NVARCHAR(255) NOT NULL,          -- Título del libro
    Autor NVARCHAR(255) NOT NULL,           -- Autor del libro
    ISBN NVARCHAR(13) UNIQUE NOT NULL,      -- ISBN del libro (13 caracteres)
    AñoPublicacion INT NOT NULL,            -- Año de publicación
    NumeroPaginas INT NOT NULL,             -- Número de páginas
    Categoria NVARCHAR(50)                  -- Categoría del libro
);

-- Tabla Usuarios
CREATE TABLE Usuarios 
(
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único para cada usuario
    Nombre NVARCHAR(255) NOT NULL,            -- Nombre del usuario
    Apellido NVARCHAR(255) NOT NULL,          -- Apellido del usuario
    NumeroSocio NVARCHAR(10) UNIQUE NOT NULL  -- Número de socio (10 caracteres)
);

-- Tabla Prestamos
CREATE TABLE Prestamos 
(
    PrestamoID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único para cada préstamo
    LibroID INT NOT NULL,                      -- Identificador del libro prestado
    UsuarioID INT NOT NULL,                    -- Identificador del usuario que realiza el préstamo
    FechaPrestamo DATETIME NOT NULL,           -- Fecha del préstamo
    FechaDevolucion DATETIME NOT NULL,         -- Fecha esperada de devolución
    FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),  -- Llave foránea que referencia a la tabla Libros
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)  -- Llave foránea que referencia a la tabla Usuarios
);

-- Tabla Categorias
CREATE TABLE Categorias 
(
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único para cada categoría
    NombreCategoria NVARCHAR(50) UNIQUE NOT NULL  -- Nombre de la categoría
);

-- Modificar la tabla Libros para incluir la categoría
ALTER TABLE Libros
ADD CategoriaID INT,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID);

-- Tabla Reservas
CREATE TABLE Reservas 
(
    ReservaID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador único para cada reserva
    LibroID INT NOT NULL,                     -- Identificador del libro reservado
    UsuarioID INT NOT NULL,                   -- Identificador del usuario que realiza la reserva
    FechaReserva DATETIME NOT NULL,           -- Fecha de la reserva
    FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),  -- Llave foránea que referencia a la tabla Libros
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)  -- Llave foránea que referencia a la tabla Usuarios
);
