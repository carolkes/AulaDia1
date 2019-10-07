insert into Flores 
values
('Margarida',3),
('Rosa',5),
('Orquídea',4),
('Violeta',2),
('Copo de Leite',7)
-- 1.3 Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade
select -- comando de seleção do banco de dados
* -- com * falamos que vamos retornar todos os campos do nosso select
from --indica a tabela que vamos selecionar para a contagem de linhas
Flores -- nossa primeira tabela de seleção 
order by Quantidade Desc -- order by ordena a coluna que queremos em 
--ordem desc(decrescente) ou asc(ascendente)
-- 1.3 Devemos retornar uma seleção com a quantidade total de flores que temos
select count(*) -- count conta a quantidade de registro onde o '*' pega todas as colunas
as 'Qtdade Flores'
from Flores