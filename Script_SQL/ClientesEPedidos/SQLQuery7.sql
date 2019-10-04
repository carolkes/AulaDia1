select * from Clientes;
select * from Pedidos;

select * from Pedidos ped
where ped.ClienteId in (select cli.Id from Clientes cli
		inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N000000001','N000000002','N000000003','N000000004'))
order by ped.Valor desc