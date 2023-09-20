Banda Twenty_One_Pilots = new Banda();
Twenty_One_Pilots.Nome = "Twenty One Pilots";

Genero Rock = new Genero();
Rock.Nome = "Rock";

Genero Rock_Alternativo = new Genero();
Rock_Alternativo.Nome = "Rock Alternativo";

Album album1 = new Album();
album1.Nome = "Blurryface";
album1.AdicionarGenero(Rock);
album1.AdicionarGenero(Rock_Alternativo);

Musica musica1 = new Musica(Twenty_One_Pilots); //Criando a instâncio do objeto
musica1.Nome = "Stressed Out"; //Adicionando valores nos atributos
musica1.Duracao = 202;
musica1.Disponivel = true;

Musica musica2 = new Musica(Twenty_One_Pilots);
musica2.Nome = "Ride";
musica2.Duracao = 214;
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicas();

Twenty_One_Pilots.AdicionarAlbum(album1);
Twenty_One_Pilots.AlbunsDaBanda();