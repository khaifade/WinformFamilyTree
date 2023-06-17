create database FTM
go
use FTM
go
create table MEMBER
(
	MemberID int not null IDENTITY(1,1) primary key,
	FirstName nvarchar(20) not null,
	LastName nvarchar(40) not null,
	DateOfBirth date not null, 
	DateOfDeath date,
	Gender nvarchar(3) not null,
	PlaceOfOrigin nvarchar(255),
	Biography nvarchar(max),
	MemberProfilePicture varbinary(MAX)

)
go
create table RELATIONSHIP_SPOUSE
(
	MemberID1 int,
	MemberID2 int,
	SpouseID int not null IDENTITY(1,1) primary key,
	constraint FK_Relationship_Spouse_Member1 foreign key (MemberID1) references Member (MemberID),
	constraint FK_Relationship_Spouse_Member2 foreign key (MemberID2) references Member (MemberID)
)
go
create table RELATIONSHIP_PARENT_CHILD
(
	ChildID int,
	ParentID int,
	primary key (ChildID, ParentID),
	constraint FK_Relationship_P_C_Child foreign key (ChildID) references Member (MemberID),
	constraint FK_Relationship_P_C_Parent foreign key (ParentID) references RELATIONSHIP_SPOUSE (SpouseID),
)