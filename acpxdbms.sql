create database real_estate;

create table properties
(
	propertyID INT primary key,
	Address varchar (255) not null,
	type_of_property varchar (100) not null,
	size_of_property int not null,
	price int not null
)

create table agents
(
	agentID INT primary key,
	name varchar (100) not null,
	gender char not null,
	contact_info varchar (20) not null,
	commission_rate dec(10,2) not null,
	username varchar (200) not null,
	password varchar (200) not null
);

create table buyers
(
	buyerID int primary key,
	name varchar (100) not null,
	contact_number varchar (20) not null,
	budget dec(20,2) not null
);

create table transactions
(
	transactionID int primary key,
	propertyID int,
	foreign key(propertyID) references properties(propertyID),
	buyerID int,
	foreign key(buyerID) references buyers(buyerID),
	agentID int,
	foreign key(agentID) references agents (agentID),
	transactiondate date not null,
	transactionamount dec(20, 2) not null
);

create table contracts
(
	contractID int primary key,
	transactionID int,
	foreign key (transactionID) references transactions(transactionID),
	terms_and_conditions varchar (1000) not null
);

create table visits
(
	visitID int primary key,
	propertyID int,
	foreign key(propertyID) references properties(propertyID),
	visitor_name varchar (255) not null,
	agentID int,
	foreign key(agentID) references agents(agentID),
	visit_date date not null,
	feedback varchar (1000) not null
)