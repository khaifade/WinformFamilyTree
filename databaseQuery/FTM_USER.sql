create database FTM_USER
go
use FTM_USER
go
create table USERDATA
(

	FirstName nvarchar(20),
	LastName nvarchar(40),
	Email varchar(50) not null primary key,
	UserPassword varchar(50) not null,
	UserProfilePicture varbinary(max)
)

