CREATE DATABASE AddressBook;

CREATE TABLE Kontakter(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Namn varchar(200) NOT NULL,
	Gatuadress varchar(200),
	Postnummer varchar(10),
	Postort varchar (200),
	Telefon varchar (20) NOT NULL,
	Epost varchar (200) NOT NULL,
	KontaktTyp varchar (20) CHECK (KontaktTyp in ('Personlig kontakt', 'Jobb kontakt', 'Övriga kontakter')) NOT NULL 
);

drop table Kontakter;

SELECT * FROM Kontakter;