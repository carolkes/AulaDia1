insert into Usuarios -- Informamos a tabela que vamos reistrar o valor
(Nome) -- As colunas qye vamos carregas as informações 
values -- informamos que os valores estarão a seguir
('Caroline') -- nossas informações na ordem das colunas*/
GO
select * from Usuarios
GO
insert into Usuarios
(Nome, Login, Senha)
values
('madu','kes','madu123')
GO
select * from Usuarios