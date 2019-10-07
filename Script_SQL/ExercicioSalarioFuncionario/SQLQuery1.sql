insert into Funcionarios
(Nome,DataInicio) -- Adicionamos 3 funcionarios na tabela de funcionarios
values -- e a data de entrada na empresa
('Caroline','03/20/2018'),
('Camila','05/15/2018'),
('Madu','03/30/2019')
update Funcionarios set Ativo = 1; --  como na tabela Funcionarios colocamos o Ativo
-- como 'default' ativo = 0 o update alterou o ativo para 1
select * from Funcionarios; -- Dessa forma conseguimos vizualizar em tabela os
-- funcionarios que adicionamos e a data de entrada na empresa

