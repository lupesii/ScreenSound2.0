Album album1 = new Album();
album1.Nome = "Blurryface";

Musica musica1 = new Musica(); //Criando a instâncio do objeto
musica1.Nome = "Stressed Out"; //Adicionando valores nos atributos
musica1.Artista = "Twenty One Pilots";
musica1.Duracao = 202;
musica1.Genero = "Rock Alternativo";
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Ride";
musica2.Artista = "Twenty One Pilots";
musica2.Duracao = 214;
musica2.Genero = "Rock Alternativo";
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicas();