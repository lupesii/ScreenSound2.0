class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AlbunsDaBanda()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}