Musica musica1 =  new Musica(); //Criando a instâncio do objeto
musica1.Nome = "Stressed Out"; //Adicionando valores nos atributos
musica1.Artista = "Twenty One Pilots";
musica1.Duracao = 300;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Bem melhor";
musica2.Artista = "Mayis";
musica2.Duracao = 294;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine(musica1.Descricao);