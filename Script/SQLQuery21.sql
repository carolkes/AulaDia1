update -- Palavra reservada que atualiza informações 
Livros -- Nossa tabela que será alterado a informação
set -- set inicializa a primeira alteração em nosso sql
Ativo = 0 -- expressão que vai ser alterada
where -- Palavra que inicializa as condições para realizar esta alteração 
Id = 
(select * from Livros order by Id desc
offset 1 rows fetch next 1 rows only)