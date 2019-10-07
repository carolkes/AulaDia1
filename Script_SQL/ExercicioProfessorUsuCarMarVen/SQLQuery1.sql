select * from Usuarios; -- Felipe - Id = 1 / Giomar - Id = 2

select * from Marcas; -- Leitura tabela marcas

select * from Carros;-- Leitura tabela Carros 

select * from Vendas; -- Leitura tabela vendas

/*update para alterar o numero default do UsuInc (porque na tabela que o
professor passou o valor era 0 e não era possível concluir os select's*/
update Usuarios set UsuInc = 1 where UsuInc = 0;
update Marcas set UsuInc = 1 where UsuInc= 0;

/*Trazendo somente as marcas que o usuario Felipe cadastrou*/
select mar.Nome
	from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
-- ou
select*from Marcas where UsuInc = 1

/*Trazendo somente as marcas que o usuario Giomar cadastrou*/
select mar.Nome
	from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
-- ou
select*from Marcas where UsuInc = 2

/*Trazendo a quantidade de marcas que o usuario Felipe cadastrou*/
select count(mar.Nome) as 'Qtd Marcas'
	from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by count(mar.Nome) desc

/*Trazendo a quantidade de marcas que o usuario Giomar cadastrou*/
select count(mar.Nome) as 'Qtd Marcas'
	from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by count(mar.Nome) desc

/*Trazendo a quantidade de marcas que o Felipe e o Giomar cadastraram*/
select count(mar.Nome) as 'Qtd Marcas'
	from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id

/*Trazendo somente os carros que o usuario Felipe cadastrou*/
select car.Modelo
	from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

/*Trazendo somente os carros que o usuario Giomar cadastrou*/
select car.Modelo
	from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

/*Trazendo a quantidade de marcas que o usuario Felipe cadastrou*/
select count(car.Modelo) as 'Qtd Carros'
	from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
order by count(car.Modelo) desc

/*Trazendo a quantidade de marcas que o usuario Giomar cadastrou*/
select count(car.Modelo) as 'Qtd Carros'
	from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by count(car.Modelo) desc

/*Trazendo a quantidade de marcas que Giomar e Felipe cadastraram*/
select count(car.Modelo) as 'Qtd Carros'
	from Carros car inner join Usuarios usu on car.UsuInc = usu.Id

/*Trazendo o valor total de vendas em 2019*/
select sum(ven.Valor) as 'Total Vendas 2019' 
from Vendas ven
where year(ven.DatInc) = 2019

/*Trazendo a quantidade total de vendas em 2019*/
select count(ven.Valor) as 'Qtd Vendas 2019'
from Vendas ven
where year(ven.DatInc) = 2019

/*Trazendo  total de vendas de cada ano cadastrado*/
select sum(ven.Valor) as 'Total',
year(ven.DatInc) as 'Ano'
from Vendas ven
group by year(ven.DatInc) order by 1 desc 

/*Trazendo  quantidade de vendas de cada ano cadastrado*/
select count(ven.Valor) as 'Qtdade Vendas',
year(ven.DatInc) as 'Ano'
from Vendas ven
group by year(ven.DatInc) order by 1 desc 

/*Trazendo o mês de cada ano que retornou a maior quantidade de vendas*/
select year(ven1.DatInc) as 'Ano',
(select top 1 month(ven.DatInc)
from Vendas ven
where year(ven.DatInc)=year(ven1.DatInc)
group by month(ven.DatInc) 
order by sum(ven.Quantidade)desc) as 'Mês'
from Vendas ven1
group by year(ven1.DatInc)
 
/*Trazendo o mês de cada ano que retornou o maior valor de vendas*/
select sum(ven.Valor) as 'Valor', month(ven.DatInc) as 'Mês' 
from Vendas ven
group by MONTH(ven.DatInc) 
order by 2 desc

/*Trazendo o valor total de vendas que Felipe realizou*/
select sum(ven.Valor) as 'Total Vendas Felipe'
from Vendas ven
where UsuInc = 1
-- ou - usando inner join
select usu.Usuario, sum(ven.Valor) as 'Total Vendas'
from Vendas ven inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%'
group by usu.Usuario

/*Trazendo o valor total de vendas que Giomar realizou*/
select sum(ven.Valor) as 'Total Vendas Giomar'
from Vendas ven
where UsuInc = 2
-- ou -usando inner join
select usu.Usuario,sum(ven.Valor) as 'Total Vendas'
from Vendas ven inner join Usuarios usu on ven.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
group by usu.Usuario

/*Trazendo quantidade total de vendas que Felipe realizou*/
select count(ven.Valor) as 'Qtidade Vendas Felipe'
from Vendas ven
where UsuInc = 1
--ou - usando inner join
select usu.Usuario, count(ven.Valor) as 'Qtdade Vendas'
from Vendas ven inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%'
group by usu.Usuario

/*Trazendo quantidade total de vendas que Giomar realizou*/
select count(ven.Valor) as 'Qtidade Vendas Giomar'
from Vendas ven
where UsuInc = 2
--ou - usando inner join
select usu.Usuario, count(ven.Valor) as 'Qtdade Vendas'
from Vendas ven inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Giomar%'
GROUP BY usu.Usuario

/*Trazendo a quantidade total de vendas que 
Felipe e Giomar realizaram ordenando do maior para menor*/
select usu.Usuario, count(ven.Valor) as 'Total Vendas'
from Vendas ven inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%' or usu.Usuario like 'Giomar%'
group by usu.Usuario
order by 1 desc

/*Trazendo o valor total das vendas que 
Felipe e Giomar realizaram ordenando do maior para menor*/
select usu.Usuario, sum(ven.Valor) as 'Total Vendas'
from Vendas ven inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%' or usu.Usuario like 'Giomar%'
group by usu.Usuario
order by 1 desc

/*Trazendo a quantidade de vendas marca mais vendida de todos os anos*/
select mar.Nome,count(ven.Valor) as 'Qtdade'
from Vendas ven inner join Carros car on ven.Carro = car.Id
inner join Marcas mar on car.Marca = mar.Id 
group by mar.Nome 
order by 2 desc

/*Trazendo o valor da marca mais vendida de todos os anos*/
select mar.Nome ,sum(ven.Valor) as 'Valor'
from Vendas ven inner join Carros car on ven.Carro = car.Id
inner join Marcas mar on car.Marca = mar.Id
group by mar.Nome
order by 2 desc

/*Trazendo a quantidade de vendas do carro mais vendido de todos os anos*/
select car.Modelo,count(ven.Valor) as 'Valor'
from Vendas ven inner join Carros car on ven.Carro = car.Id
group by car.Modelo
order by 2 desc

/*Trazendo o valor do carro mais vendido de todos os anos*/
select car.Modelo,sum(ven.Valor) as 'Valor'
from Vendas ven inner join Carros car on ven.Carro = car.Id
group by car.Modelo
order by 2 desc

