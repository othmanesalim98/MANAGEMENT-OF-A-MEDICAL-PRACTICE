create database gestion_cabinet_m�dicale
use gestion_cabinet_m�dicale

create table M�decin
(
    CodeM int primary key,
	NomM varchar(20),check(NomM like '[A-Za-z]%[A-Za-z]' ),
	Pr�nomM varchar(20),check (Pr�nomM like '[A-Za-z]%[A-Za-z]'),
	Sp�cialit� varchar(50),check(Sp�cialit� like '[A-Za-z]%[A-Za-z]'),
	Adresse varchar(100),
	EmailM varchar(100),
	T�l�M int,

)
 

insert into M�decin values(1,'alami','slimanie','g�n�raliste','hay baraka n�20 rue 40','alamisli12@gmail.com',054545)


 create table Mutuelle
 (
    CodeMu int primary key,
	NomMu varchar(20),check (NomMu like '[A-Za-z]%[A-Za-z]'),
 ) 

 insert into Mutuelle values(1,'cnops'),
                            (2,'cnss'),
							(3,'rma'),
							(4,'axa'),
							(5,'lydec'),
							(6,'one')
							




create table Journ�e
(
   NumJ int primary key,
   Heur_D time,
   Heur_F time, 
)

insert into Journ�e values (1,'09:00:00','17:00:00'),
                           (2,'09:00:00','17:00:00'),
						   (3,'08:30:00','13:30:00'),
						   (4,'09:00:00','17:00:00'),
						   (5,'09:00:00','17:00:00'),
						   (6,'08:00:00','13:30:00')


create table Rendez_vous
(
  NumR int primary key ,
  DateR date,
  HeurR time,
  journ�e int references Journ�e(numJ)
)


insert into Rendez_vous values (1,'2019/03/11','10:10:30',1)
   
insert into Rendez_vous values (2,'2019/03/12','09:45:00',2),
							   (3,'2019/03/13','09:15:40',3),
							   (4,'2019/03/14','14:00:15',4)


create table M�dicament 
(
   
   NumM�di int primary key ,
   NomM�di Varchar(20),
   Dosage Varchar(20) ,
   Formes varchar(30)
)

insert into M�dicament values(1,'m�di1','10ml','sirop'),
                             (2,'m�di2','500mg','pommade'),
							 (3,'m�di3','50mg','pilule'),
							 (4,'m�di4','1000mg','comprim�')

create table Patient
(
     CIN varchar(20) primary key ,
	 NomP  Varchar(20),check(NomP like '[A-Za-z]%[A-Za-z]'),
	 Pr�nomP Varchar(20),check(Pr�nomP like '[A-Za-z]%[A-Za-z]'),
	 DateN date,
	 Sexe Varchar(20),
	 Email_P Varchar (50),
	 Adresse_P Varchar (50),
	 T�l_P int , 
	 Mutuelle int references Mutuelle(codeMu),	 	 
	 rendez_vous int references Rendez_vous(NumR)
)


 
insert into Patient values ('BH312','mohamed','karami','1969/06/10','Homme','karami123@gmail.com','adresse1',0602010546,1,2)
insert into Patient values('BB510120','karime','safi','1998/06/12','Homme','karime98@gmail.com','haysalamn�20rue14',0660154872,3,4),
				            ('BL881010','sara','maha','1977/09/28','Femmme','maha18@gmail.com','sidimaaroufn�30 rue45',0618031247,4,3)
insert into Patient values('1','ff','ss','2000/02/12','Femme','gggg','nnnn',021225455,4,2)
insert into Patient values('mm','ff','ss','2000/02/12','Femme','gggg','nnnn',021225455,2,3)
select * from Patient				   

create table Consultation
(
    NumCon int primary key,
	Diagnostic varchar(20),
	DateCons date ,
	poids float,
	tension int ,
	Prix decimal,
	m�decin int references M�decin(CodeM),
	Patient varchar(20) references Patient(CIN)
)

insert into Consultation values (1,'diagno1','2018/06/15',75.50,15,500,1,'BB510120'),
                                (2,'diagno2','2019/05/16',80,12,200,1,'BB510120'),
								(3,'diagno3','2019/03/18',65,10,200,1,'BL881010')


create table Ordonnance
(
   
    NumO int primary key ,
	Qtte int,
	dur�e int,
	Medicament int references M�dicament(NumM�di),
	Consultation int references consultation(NumCon)	
)


insert into Ordonnance values (1,2,3,2,2),
                              (2,3,5,1,3),
							  (3,1,15,3,1)




 create trigger rendez_vous_20
 on  Rendez_vous
 for insert 
 as 
 begin 
    declare @nbr int 
	set @nbr =(select count(*) from Rendez_vous
	            where DateR in (select DateR from inserted))
	if(@nbr >20)
	rollback
end
--la listes des patients ont b�n�fici� de la mutuelle 
  create proc list_patient_mutuelle
  as
  begin
  select *
  from Patient
  where Mutuelle in (select codeMu
                   from Mutuelle)
end
--chercher les informations d'un ancien patient 
create proc recharche_Name
   
  @Nom varchar(20)
    
	as 
	begin 
	select * from Patient 
	where NomP like @Nom
	end




select *
from Mutuelle m 
join Patient p
on m.CodeMu=p.Mutuelle


