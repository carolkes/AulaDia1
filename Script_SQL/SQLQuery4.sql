select
car.Modelo, -- Coluna da nossa tabela carros Modelo
mar.Nome,-- Coluna da nossa tabela Marcas Nome
car.Placa,-- Coluna da nossa tabela Carros Placa
car.Ano-- Coluna da nossa tabela Carro Ano
from -- Indicador que vamos selecionar uma tabela
Carros-- Tabela que vamos selecionar 
car -- Abreviamos e criamos um alias para chamar e ficar mais fácil
inner-- Indicador que ambas as tabelas devem estar relacionadas com os dados 
join -- Indicador do banco que junta uma tabela a outra
Marcas -- Nossa tabela que vamos juntar a Carros
mar-- abreviação da nossa tabela de Marcas para facilitar as referências 
on -- Indicador que vamos mostrar como vamos relacionar as informações
car.MarcaCodigo = mar.Codigo-- Aqui informamos que carros tem um código
-- igual em Marcas e portanto a referência de Marcas seria a coluna
--código com isso ele nos tras a linha que temos essa referência e podemos utilizar
-- todas as colunas da linha com informação