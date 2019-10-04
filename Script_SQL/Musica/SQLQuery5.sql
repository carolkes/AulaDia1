insert into PlayList values ('L-O-V-E','Nat King Cole','Jazz')

select Genero, count(Artista) as 'Qtdade Músicas'
from PlayList 
group by Genero 

select distinct Genero from PlayList

select * from PlayList
 
select Artista,count(Nome) as 'Qtdade'
from PlayList
group by Artista