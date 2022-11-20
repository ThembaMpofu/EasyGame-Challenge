use master;
GO 
Create database Transactions;
use master;
go
use Transactions;

create table TransactionType(
TransactionTypeID smallint not null primary key,
TransactionTypeName nvarchar(50) not null)


Create table Client(
ClientID int not null primary key,
name nvarchar(50) not null,
Surname nvarchar(50) not null,
clientBalance decimal(18,2)not null
)

create table [Transaction](
TransactionId bigint not null primary key,
Amount decimal(18,2) not null,
TransactionTypeID smallint foreign key (TransactionTypeID) REFERENCES TransactionType(TransactionTypeID) not null,
ClientID int foreign key(ClientID) REFERENCES Client(ClientID) not null,
Comment nvarchar(100)
)

insert into TransactionType(TransactionTypeID,TransactionTypeName)
values('1','Debit');
insert into TransactionType(TransactionTypeID,TransactionTypeName)
values('2','Credit');

insert into Client(ClientID,name,Surname,clientBalance)
values(1,'Peter','Parker',1000.00);
insert into Client(ClientID,name,Surname,clientBalance)
values(2,'Tony','Stark',800000.00);
insert into Client(ClientID,name,Surname,clientBalance)
values(3,'Bruce','Banner',254111.00);

insert into [Transaction](TransactionId,Amount,TransactionTypeID,ClientID,Comment)
values(1,1000.00,1,1,'Winnings');
insert into[Transaction](TransactionId,Amount,TransactionTypeID,ClientID,Comment)
Values(4,-500.00,2,3,'losing');
insert into [Transaction](TransactionId,Amount,TransactionTypeID,ClientID,Comment)
values(5,-9000.00,2,2,'losing');

