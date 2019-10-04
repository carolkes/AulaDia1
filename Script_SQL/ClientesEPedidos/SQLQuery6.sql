select * from Pedidos;
select * from Clientes;

select ped. * from Pedidos ped
	inner join Clientes cli on ped.ClienteId = cli.Id
where cli.Nome = 'Vinícius';

select -- Iniciando o select
IIF -- Iniciamos um if dentro de um select. O mesmo pode mostrar ou não uma informação
(SUM(ped.Valor) -- Somamos os valores de todos os pedidos feitos
>700,'BRINDE!','Não Ganhou Nada') as 'Resultado', -- condição onde se o valor
-- maior que 700, lança a msg "Brinde" se não lança "não ganhou nada"
SUM(ped.Valor) as 'Total', -- soma o valor total que cada 'nome' comprou
cli.Nome -- ao invés de aparecer o ID que estávamos usando anteriormente,
-- "chamamos" o item 'nome' para aparecer na tabela 
from Pedidos ped
	inner join Clientes cli on ped.ClienteId = cli.Id
group by cli.Nome