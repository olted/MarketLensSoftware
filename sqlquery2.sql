USE master ;  
GO  
CREATE DATABASE MSFT  
ON   
( NAME = MSFT_dat,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MSFTdat.mdf' )  
LOG ON  
( NAME = users_log,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MSFTlog.ldf') ;  
GO  