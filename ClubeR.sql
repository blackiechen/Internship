create Database ClubeR 
go
use ClubeR
go

create table LoginPrograma(
	username varchar (50) not null,
	nomeU varchar(100) not null,
	codigo int not null,
	acesso int,
	escalao int,
	primary key (username)
)
go

create table Equipa(
	idEquipa int identity (1,1) primary key,
	nomeE varchar(100),
	desporto varchar(100),
	username varchar(50),
	CONSTRAINT FKusername FOREIGN KEY (username) REFERENCES LoginPrograma (username)
)
go

create table Pais(
	codPais int identity(1,1) not null,
	nome varchar(50) not null,
	primary key (codPais)
)
go

create table Jogador(
	idJogador int identity (1,1) primary key,
	nomeJ varchar(100),
	posicao varchar(100),
	idEquipa int,
	codPais int,
	CONSTRAINT FKcodPais FOREIGN KEY (codPais) REFERENCES Pais (codPais),
	CONSTRAINT FKidEquipa FOREIGN KEY (idEquipa) REFERENCES Equipa (idEquipa)
)



delete from LoginPrograma;
delete from Equipa;
delete from Pais;
delete from Jogador;

drop table LoginPrograma;
drop table Equipa;
drop table Pais;
drop table Jogador;

select * from LoginPrograma;
select * from Equipa;
select * from Pais;
select * from Jogador;