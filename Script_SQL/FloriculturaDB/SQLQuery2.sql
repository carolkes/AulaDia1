-- 2.2 Devemos inserir 2 funcionários conforme pedido em exercício
insert into Funcionarios
(Nome) 
values
('Caroline'),
('Vinícius')
--2.3 Devemos cadastrar 5 produtos Ambev com seus respectivos valores
insert into Produtos 
(Nome, Valor) 
values
('Skol Beats Senses 313ml',5.49),
('Budweiser 550ml',6.99),
('Stella Artois 275ml',3.49),
('Patagonia Bohemian Pil 740ml', 15.90),
('Corona Extra 355ml',4.99)
/* 2.4 Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, 
sendo 2 para o primeiro funcionario e 1 para o segundo
lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5*/
select * from Funcionarios
select * from Produtos
insert into Pedidos (FuncionarioId,ProdutoId,Quantidade)
values
(1, -- equivale ao id do funcionario cadastrado (caroline)
10, --  equivale ao id da cerveja cadastrada (skol beats)
2),-- equivale a quantidade de cervejas que o funcionario quer
(1,12,1),
(1,12,1),
(2,11,3),
(2,13,1),
(2,10,2)
-- 2.5 Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
select * from Funcionarios Order By Nome
-- 2.6 Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select * from Produtos order by Valor desc
-- 2.7 Vamos listar em uma seleção de nossos pedidos por funcionario 
--trazendo o nome do funcionario
select 
ped.Id,
fun.Nome,
ped.ProdutoId,
ped.Quantidade
from Pedidos ped 
		inner join Funcionarios fun on ped.FuncionarioId = fun.Id
-- 2.8 Vamos listar em uma seleção de nossos pedidos agrupando por 
-- funcionario os pedidos e somando sua respectiva quantidade de itens
select 
fun.Nome,
sum(ped.Quantidade) as 'Quantidade' 
from Pedidos ped
		inner join Funcionarios fun on ped.FuncionarioId = fun.Id
group by fun.Nome		
-- 2.9 Vamos listar em uma seleção de nossos pedidos agrupando por 
-- funcionario os pedidos e somando seu valor total  lembrando que o 
-- valor total e a a "quantidade * valor"

select
fun.Nome,
sum(ped.Quantidade * pro.Valor) as 'Valor Total' 
from Pedidos ped
		inner join Funcionarios fun on ped.FuncionarioId = fun.Id
		inner join Produtos pro on ped.ProdutoId =  pro.Id
group by fun.Nome
select * from Produtos
select * from Pedidos
-- 2.10 Vamos retornar em uma seleção nosso produto mais pedido dentro 
-- de nossa base de dados
select top 1 
pro.Nome, 
sum(ped.Quantidade) as 'Quantidade' from Produtos pro 
		inner join Pedidos ped on pro.Id = ped.ProdutoId 
group by pro.Nome
order by sum(ped.Quantidade) desc
-- left join traz todos os produtos da lista
-- inner Join traz os produtos que foram comprados

-- 2.11 Vamos retornar em uma seleção o produto que gerou
-- a maior receita dentro de nossa base de dados 
select TOP 1
pro.Nome,
sum(ped.Quantidade * pro.Valor) 'ReceitaTotal' from Produtos pro 
		inner join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
order by 'ReceitaTotal' desc

-- 2.12 Vamos retornar em uma seleção para o primeiro funcionario 
-- os produtos que ele não comprou de nosso mercado
select * from Produtos
where id not in(
select ped.ProdutoId from Funcionarios fun 
		inner join Pedidos ped on fun.Id = ped.FuncionarioId
where fun.Nome like 'Caroline%')

-- Aqui tras os que não foram comprados apenas
select * from Produtos pro 
		left join Pedidos ped on pro.Id = ped.ProdutoId
where ped.ProdutoId is null

-- 2.13 Vamos retornar em uma seleção os produtos ordenados pela 
-- ordem do mais comprado para o menos comprado
select pro.Nome, count(ped.ProdutoId) as 'Quantidade'
from Produtos pro
		left join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
order by 'Quantidade' desc