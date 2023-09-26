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

Musica musica1 = new Musica(Twenty_One_Pilots); //Criando a instâncio do objeto
musica1.Nome = "Stressed Out"; //Adicionando valores nos atributos
musica1.Duracao = 202;
musica1.Disponivel = true;

//Musica 2

Musica musica2 = new Musica(Twenty_One_Pilots);
musica2.Nome = "Ride";
musica2.Duracao = 214;
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicas();

Twenty_One_Pilots.AdicionarAlbum(album1);
Twenty_One_Pilots.AlbunsDaBanda();