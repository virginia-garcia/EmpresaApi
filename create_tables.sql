

-- 1. Tabla de Categorías 
CREATE TABLE Categories (
    -- Clave Primaria
    CategoryID INT PRIMARY KEY IDENTITY(1,1), 
    
    CategoryName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255)
);

-- 2. Tabla de Productos 
CREATE TABLE Products (
    -- Clave Primaria
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    CategoryID INT NOT NULL, 
    
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- 3. Tabla de Empleados 
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Title NVARCHAR(50), 
    Country NVARCHAR(50),
    
    BirthDate DATE NOT NULL 
);

--Datos usados como prueba
-- Datos para Categories
INSERT INTO Categories (CategoryName, Description) VALUES
('Bebidas', 'Refrescos y jugos'),
('Comestibles', 'Alimentos secos y envasados'),
('Electrónica', 'Dispositivos y gadgets');

-- Datos para Productos
INSERT INTO Products (ProductName, CategoryID) VALUES
('Coca Cola', 1),
('Agua Mineral', 1),
('Pan Integral', 2),
('Laptop Gamer', 3);

-- Datos para Empleados
INSERT INTO Employees (FirstName, LastName, Title, Country, BirthDate) VALUES
('Ana', 'Gomez', 'Manager', 'Argentina', '1980-05-10'),
('Juan', 'Perez', 'Developer', 'Chile', '1995-12-25'),
('Maria', 'Lopez', 'Developer', 'Argentina', '1975-01-01'),
('Carlos', 'Díaz', 'Manager', 'Mexico', '1988-08-15');
