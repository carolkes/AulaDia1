/*Forma de mostrar a soma dos 3 salários de cada funcionário*/
select fun.Nome,
sum(sal.Valor) as 'Total 3 meses'
from Funcionarios fun
	 inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome
/*Forma de mostrar a média dos 3 salários de cada funcionário*/
select fun.Nome,
avg(sal.Valor) as 'Média 3 meses',
/*Forma de mostrar a quatidade salários que cada funcionário teve*/
count(sal.Valor) as 'Quantidade Pgtos',
/*outra forma de calcular a média*/
sum(sal.Valor) / count(sal.Valor) as 'Nova Média',
sum(sal.Valor) as 'Total'
from Funcionarios fun
	 inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome
order by sum(sal.Valor) desc

/*Aqui Informamos e selecionamos os itens da tabela que tem o Id entre 3 e 8*/
select * from Salarios
where Id between 3 and 8
/*Aqui informamos para aparecer na tabela somente os funcionarios com
data de criação entre as datas colocadas a baixo*/
select * from Salarios 
where DataCriacao between '07/05/2019' and '07/08/2019'
/*Aqui pedimos para mostrar os 3 maiores salários dos funcionarios do mes 7 a 9*/
select top 3 * from Salarios
order by Valor desc
/*Aqui mostramos os salários entre os Id's maiores que 3 e menores que 8*/
select * from Salarios
where Id >= 3 and Id <=8
/*update significa alteração de algum dado
Aqui adicionamos a data de saída de um funcionário, desativando-o do sistema*/
update Funcionarios
set 
DataSaida = '12/12/2019',
DataAlteracao = getdate(),
Ativo = 0
where Nome like 'Madu%'
/*Aqui mensionamos somente os funcionaios que possuem a silaba colocada a baixo
no exemplo 'ma%' e '%du'*/
select * from Funcionarios where Nome like 'Ma%'
select * from Funcionarios where Nome like '%du'
/*aqui pedimos para mensionar todos os funcionarios que possuem a letra 'a' no nome*/
select * from Funcionarios where Nome like '%a%'
/*Aqui pedimos para aparecer a data de inicio e de saida do funcionario*/
select
Nome,
convert (varchar(10),DataInicio, 103) as 'Inicio',
convert (varchar(10),DataInicio, 103) as 'Saida'
from Funcionarios