-- Crear la base de datos
CREATE DATABASE BibliotecaDB;

-- Usar la base de datos
USE BibliotecaDB;

-- Tabla Libros
CREATE TABLE Libros 
(
    LibroID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador �nico para cada libro
    Titulo NVARCHAR(255) NOT NULL,          -- T�tulo del libro
    Autor NVARCHAR(255) NOT NULL,           -- Autor del libro
    ISBN NVARCHAR(13) UNIQUE NOT NULL,      -- ISBN del libro (13 caracteres)
    A�oPublicacion INT NOT NULL,            -- A�o de publicaci�n
    NumeroPaginas INT NOT NULL,             -- N�mero de p�ginas
    Categoria NVARCHAR(50)                  -- Categor�a del libro
);

-- Tabla Usuarios
CREATE TABLE Usuarios 
(
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador �nico para cada usuario
    Nombre NVARCHAR(255) NOT NULL,            -- Nombre del usuario
    Apellido NVARCHAR(255) NOT NULL,          -- Apellido del usuario
    NumeroSocio NVARCHAR(10) UNIQUE NOT NULL  -- N�mero de socio (10 caracteres)
);

-- Tabla Prestamos
CREATE TABLE Prestamos 
(
    PrestamoID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador �nico para cada pr�stamo
    LibroID INT NOT NULL,                      -- Identificador del libro prestado
    UsuarioID INT NOT NULL,                    -- Identificador del usuario que realiza el pr�stamo
    FechaPrestamo DATETIME NOT NULL,           -- Fecha del pr�stamo
    FechaDevolucion DATETIME NOT NULL,         -- Fecha esperada de devoluci�n
    FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),  -- Llave for�nea que referencia a la tabla Libros
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)  -- Llave for�nea que referencia a la tabla Usuarios
);

-- Tabla Categorias
CREATE TABLE Categorias 
(
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador �nico para cada categor�a
    NombreCategoria NVARCHAR(50) UNIQUE NOT NULL  -- Nombre de la categor�a
);

-- Modificar la tabla Libros para incluir la categor�a
ALTER TABLE Libros
ADD CategoriaID INT,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID);

-- Tabla Reservas
CREATE TABLE Reservas 
(
    ReservaID INT PRIMARY KEY IDENTITY(1,1),  -- Identificador �nico para cada reserva
    LibroID INT NOT NULL,                     -- Identificador del libro reservado
    UsuarioID INT NOT NULL,                   -- Identificador del usuario que realiza la reserva
    FechaReserva DATETIME NOT NULL,           -- Fecha de la reserva
    FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),  -- Llave for�nea que referencia a la tabla Libros
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)  -- Llave for�nea que referencia a la tabla Usuarios
);
