class Album
{
    private List<Musica> Musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");

        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista}");
            Console.WriteLine($"Duração: {musica.Duracao}");
            Console.WriteLine($"Disponivel: {musica.Disponivel}\n");
        }

        Console.WriteLine($"Este álbum tem uma duração de {DuracaoTotal} segundos");
    }


}