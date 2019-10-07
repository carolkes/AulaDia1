select gen.Nome as 'Genero',
	   art.Nome as 'Artista',
	   can.Nome as 'Canção' from Generos gen
	   inner join Artistas art on gen.Id = art.GeneroId
	   inner join Cancoes can on art.Id = can.ArtistaId

/*Mostra a quantidade de artistas de cada genero*/
select gen.Nome as 'Genero',
		count(art.Nome) as 'Quantidade Artistas'
	   from Generos gen
	   inner join Artistas art on gen.Id = art.GeneroId
group by gen.Nome

select gen.Nome as 'Genero',
		count(can.Nome) as 'Quantidade Canções'
	   from Generos gen
	   inner join Artistas art on gen.Id = art.GeneroId
	   inner join Cancoes can on art.Id = can.ArtistaId
group by gen.Nome

