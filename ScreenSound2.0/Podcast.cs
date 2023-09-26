class PodCast
{
    public PodCast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    private List<Episodio> ListaEpisodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => ListaEpisodios.Count;

    public void AdicionarEpisodios(Episodio episodio)
    {
        ListaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast: {Nome}, Apresentador: {Host}");
        foreach(Episodio episodio in ListaEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de Episódios: {TotalEpisodios}");
    }
}
