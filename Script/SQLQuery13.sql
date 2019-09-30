update Livros
set Nome = 'não informado'
where Login is null
GO
select * from Livros