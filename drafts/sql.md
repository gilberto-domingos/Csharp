# Rascunho de comandos : SqlServer cmd commands

SELECT 
    a.IdAutor,
    a.Nome,
    a.Sobrenome
FROM 
    Livros l
INNER JOIN 
    Autores a ON l.IdAutor = a.IdAutor
WHERE 
    l.IdLivro = 4;


SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'Autores';
go



EXEC sp_help 'Autores';
go


EXEC sp_rename 'dbo.Autores.Id', 'IdAutor', 'COLUMN';
go

USE csnetdb;
GO

SELECT DB_NAME() AS CurrentDatabase;
go

CREATE TABLE Autores (
    IdAutor INT PRIMARY KEY IDENTITY(1,1),     -- Chave primária
    Nome NVARCHAR(100) NOT NULL,           -- Nome do autor
    Sobrenome NVARCHAR(100) NOT NULL       -- Sobrenome do autor
);
GO

CREATE TABLE Livros (
    IdLivro INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100) NOT NULL,
    IdAutor INT NOT NULL,
    FOREIGN KEY (IdAutor) REFERENCES Autores(IdAutor)
);



SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Livros';
go


INSERT INTO Autores (Nome, Sobrenome) VALUES
('Machado', 'de Assis'),
('Clarice', 'Lispector'),
('Jorge', 'Amado'),
('Cecília', 'Meireles'),
('Carlos', 'Drummond de Andrade');
go

INSERT INTO Livros (Titulo, IdAutor) VALUES
('Memórias Póstumas de Brás Cubas', 1),  
('A Hora da Estrela', 2),                
('Capitães da Areia', 3),               
('Passaredo', 4),                       
('Alguma Poesia', 5);                   
go

select * from Livros;
go

select * from Livros WHERE id = 4;


select * from Autores where IdAutor = 3;
go

SELECT DB_NAME() AS CurrentDatabase;
GO

SELECT * From Autores;
go

sp_help Autores;
go

SELECT 
    COLUMN_NAME AS NomeColuna, 
    DATA_TYPE AS Tipo, 
    CHARACTER_MAXIMUM_LENGTH AS Tamanho
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Autores';
go

select name from sys.tables where name = 'Autores';
go




drop table Autores;
drop table Livros;



SELECT * FROM Autores; 

INSERT INTO Livros (Titulo, AutorId) VALUES
('Dom Casmurro', 1),
('A Hora da Estrela', 2),
('Capitães da Areia', 3),
('Romanceiro da Inconfidência', 4),
('A Rosa do Povo', 5);

use csnetdb;

SELECT c.name AS ColumnName, t.name AS DataType
FROM sys.columns c
JOIN sys.types t ON c.user_type_id = t.user_type_id
WHERE object_id = OBJECT_ID('Produto');
GO

CREATE TABLE SistemaVendas.Clientes (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Preco DECIMAL(18,2)
);
GO

USE csnetdb;
GO

SELECT name AS TableName
FROM sys.tables;


SELECT name 
FROM sys.databases 
WHERE name = 'csnetdb';


SELECT DB_NAME() AS CurrentDatabase;
GO


 select name from sys.tables where name = 'Produto';

1> select table_name
2> from information_schema.tables
3> where table_schema = 'db_vendas'
4> go

1> SELECT schema_name FROM information_schema.schemata;
2> go

(4 rows affected)
1> use master;
2> go
Changed database context to 'master'.


1> select name from sys.databases;
2> go

CREATE DATABASE csnetdb;

