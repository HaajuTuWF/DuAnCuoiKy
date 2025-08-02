IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DuAnWeb')
BEGIN
    CREATE DATABASE DuAnWeb;
END
GO

USE DuAnWeb;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        username NVARCHAR(50) PRIMARY KEY,
        password NVARCHAR(256) NOT NULL
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SanPham')
BEGIN
    CREATE TABLE SanPham (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MoTaAcer')
BEGIN
    CREATE TABLE MoTaAcer (
        ID INT PRIMARY KEY IDENTITY(1,1),
        CardDoHoa NVARCHAR(MAX),
        ManHinh NVARCHAR(MAX),
        Chip NVARCHAR(MAX),
        RAM NVARCHAR(50),
        ROM NVARCHAR(50)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AnhAcerAP7')
BEGIN
    CREATE TABLE AnhAcerAP7 (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Anh1 NVARCHAR(MAX),
        Anh2 NVARCHAR(MAX),
        Anh3 NVARCHAR(MAX),
        Anh4 NVARCHAR(MAX),
        Anh5 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MoTaIp')
BEGIN
    CREATE TABLE MoTaIp (
        ID INT PRIMARY KEY IDENTITY(1,1),
        ManHinh NVARCHAR(MAX),
		Camera NVARCHAR(MAX),
        Chip NVARCHAR(MAX),
        RAM NVARCHAR(50),
        ROM NVARCHAR(50)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Anhip')
BEGIN
    CREATE TABLE AnhIp (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Anh1 NVARCHAR(MAX),
        Anh2 NVARCHAR(MAX),
        Anh3 NVARCHAR(MAX),
        Anh4 NVARCHAR(MAX),
        Anh5 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cart')
BEGIN
    CREATE TABLE Cart (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
		SoLuong INT
    );
END
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LapTop')
BEGIN
    CREATE TABLE Laptop (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LapTopAll')
BEGIN
    CREATE TABLE LaptopAll (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PC')
BEGIN
    CREATE TABLE PC (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PhuKien')
BEGIN
    CREATE TABLE PhuKien (
        ID INT PRIMARY KEY IDENTITY(1,1),
    TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Phone')
BEGIN
    CREATE TABLE Phone (
        ID INT PRIMARY KEY IDENTITY(1,1),
        TenSp NVARCHAR(MAX),
        GiaSp DECIMAL(18, 0),
        LinkAnh NVARCHAR(MAX),
        CauHinh1 NVARCHAR(MAX),
		CauHinh2 NVARCHAR(MAX)
    );
END
GO