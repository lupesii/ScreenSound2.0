class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> Musicas = new List<Musica>();

    private List<Genero> AlbumGenero = new List<Genero>();

    public string Nome { get; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void AdicionarGenero(Genero album)
    {
        AlbumGenero.Add(album);
    }


    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");

        foreach (Genero GeneroAlbum in AlbumGenero)
        
            if (GeneroAlbum.Nome != null)
            {
                Console.WriteLine($"Gêneros do Album: {GeneroAlbum.Nome}");
            }
            else
            {
                Console.WriteLine("Não foi descrito o nome deste gênero. Mas, pode existir uma descrição.\n");
            }

            foreach (var musica in Musicas)
        {
            Console.WriteLine($"\nMúsica: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista}");
            Console.WriteLine($"Duração: {musica.Duracao}");
            Console.WriteLine($"Disponivel: {musica.Disponivel}\n");
        }

        Console.WriteLine($"Este álbum tem uma duração de {DuracaoTotal} segundos");
    }


}