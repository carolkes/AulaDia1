insert into Usuarios
(Nome,Login,Senha)
values
('Vin�cius','caroline','madu')
GO
select * from Usuarios
update Usuarios set Ativo = 0 where Id = 8