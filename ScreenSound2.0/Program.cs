//Banda

Banda Twenty_One_Pilots = new Banda("Twenty One Pilots");

//Gênero

Genero Rock = new Genero("Rock");

Genero Rock_Alternativo = new Genero("Rock Alternativo");

// Album
 
Album album1 = new Album("Blurryface");
album1.AdicionarGenero(Rock);
album1.AdicionarGenero(Rock_Alternativo);

//Musica 1

Musica musica1 = new Musica(Twenty_One_Pilots, "Stressed Out"); //Criando a instâncio do objeto
musica1.Duracao = 202;
musica1.Disponivel = true;

//Musica 2

Musica musica2 = new Musica(Twenty_One_Pilots, "Ride");
musica2.Duracao = 214;
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
Twenty_One_Pilots.AdicionarAlbum(album1);

//PodCast

PodCast PodPah = new PodCast("Flow", "PodPah");

//Episódios
Episodio ep1 = new(1, "Testando", 30);
ep1.AdicionarConvidados("Lucas(Desenvolvedor Full Stack)");
ep1.AdicionarConvidados("Ricardo(Desenvolvedor Back End)");

Episodio ep2 = new(2, "Agora Sim", 10);
ep2.AdicionarConvidados("Maria(Designer)");
ep2.AdicionarConvidados("Anna(Dentista)");;

PodPah.AdicionarEpisodios(ep1);
PodPah.AdicionarEpisodios(ep2);
PodPah.ExibirDetalhes();
