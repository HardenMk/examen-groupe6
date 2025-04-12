--Insert or Update personne
create procedure sp_insert_personne
	@id int,@nom varchar(50),@postnom varchar(50),
	@prenom varchar(50),@sexe varchar(1)
as
begin
	if not exists(select * from personne where id=@id)
		insert into personne(id,nom,postnom,prenom,sexe) values 
		(@id,@nom,@postnom,@prenom,@sexe)
	else
		update personne set nom=@nom,postnom=@postnom,prenom=@prenom,
		sexe=@sexe where id=@id
end
go

--Delete personne
create procedure sp_delete_personne
	@id int
as
begin
	if exists(select * from personne where id=@id)
		delete from personne where id=@id
end
go

--Select all personne
create procedure sp_select_personnes
as
begin 
	select id,nom,postnom,prenom,sexe from personne order by nom asc
end
go

--Select one personne
create procedure sp_select_personne
	@id int
as
begin
	select id,nom,postnom,prenom,sexe from personne 
	where id=@id
end
go

--Insert or Update telephone
create procedure sp_insert_telephone
	@id int,@id_proprietaire int,@initial varchar(4),
	@numero varchar(9)
as
begin
	if not exists(select * from telephone where id=@id)
		insert into telephone(id,id_proprietaire,initial,numero) values 
		(@id,@id_proprietaire,@initial,@numero)
	else
		update telephone set id_proprietaire=@id_proprietaire,
		initial=@initial,numero=@numero where id=@id
end
go

--Delete telephone
create procedure sp_delete_telephone
	@id int
as
begin
	if exists(select * from telephone where id=@id)
		delete from telephone where id=@id
end
go

--Select all telephone
create procedure sp_select_telephones
as
begin
	select id,id_proprietaire,initial,numero from telephone order by numero asc
end
go

--Select all telephone of personne
create procedure sp_select_telephones_personne
	@id_personne int	
as
begin
	select t.id,p.nom+' '+p.postnom+' '+p.prenom,id_proprietaire,initial,numero
	from telephone t inner join personne p on t.id_proprietaire=p.id
	 where id_proprietaire=@id_personne
	order by numero asc
end
go

--Select one telephone
create procedure sp_select_telephone
	@id int
as
begin
	select p.nom + ' ' + ISNULL(p.postnom,'') + ' ' + ISNULL(p.prenom,'') as nom,id_proprietaire,initial,numero
	from telephone t inner join personne p on t.id_proprietaire=p.id
	where t.id=@id
end
go

--Stored Procedure for report of persons
create procedure sp_liste_personnes
as
begin
	select personne.id,personne.nom + ' ' + ISNULL(personne.postnom,'') + ' ' + ISNULL(personne.prenom,'') as nom,
	personne.sexe,telephone.id as idtel,telephone.initial + telephone.numero as numero
	from personne
	left outer join telephone 
	on personne.id=telephone.id_proprietaire
end
go
--inseert et update adresse
create procedure sp_insert_adresse
	@id int,@quartier varchar(50),@commune varchar(50),
	@ville varchar(50),@pays varchar(50)
as
begin
	if not exists(select * from personne where id=@id)
		insert into adresse(id,quartier,commune,ville,pays) values 
		(@id,@quartier,@commune,@ville,@pays)
	else
		update adresse set quartier=@quartier,commune=@commune,ville=@ville,
		pays=@pays where id=@id
end
go

--Delete adresse
create procedure sp_delete_adresse
	@id int
as
begin
	if exists(select * from adresse where id=@id)
		delete from adresse where id=@id
end
go

--Select all adresse
create procedure sp_select_adresses
as
begin 
	select id,quartier,commune,ville,pays from adresse order by pays asc
end
go

--Select one adresse
create procedure sp_select_adresse
	@id int
as
begin
	select id,quartier,commune,ville,pays from adresse 
	where id=@id
end
go

--inseert et update domicile
create procedure sp_insert_domicile
	@id int,@id_personne int,@id_adresse int,
	@avenue varchar(50),@numero_avenue int
as
begin
	if not exists(select * from domicile where id=@id)
		insert into domicile(id,id_personne,id_adresse,avenue,numero_avenue) values 
		(@id,@id_personne,@id_adresse,@avenue,@numero_avenue)
	else
		update domicile set @id_personne=@id_personne,id_adresse=@id_adresse,avenue=@avenue,
		numero_avenue=@numero_avenue where id=@id
end
go

--Delete domicile
create procedure sp_delete_domicile
	@id int
as
begin
	if exists(select * from domicile where id=@id)
		delete from domicile where id=@id
end
go

--Select all domicile
create procedure sp_select_domiciles
as
begin 
	select id,id_adresse,id_personne,avenue,numero_avenue from domicile 
	order by id asc
end
go

