# Rascunho de comandos SQLCMD

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

