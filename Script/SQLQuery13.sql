update Livros
set Nome = 'n�o informado'
where Login is null
GO
select * from Livros