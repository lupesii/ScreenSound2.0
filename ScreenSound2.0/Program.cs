﻿Genero genero1 = new Genero();
genero1.Nome = "Rock";

Album album1 = new Album();
album1.Nome = "Blurryface";
album1.AdicionarGenero(genero1);

Musica musica1 = new Musica(); //Criando a instâncio do objeto
musica1.Nome = "Stressed Out"; //Adicionando valores nos atributos
musica1.Artista = "Twenty One Pilots";
musica1.Duracao = 202;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Ride";
musica2.Artista = "Twenty One Pilots";
musica2.Duracao = 214;
musica2.Disponivel = false;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicas();