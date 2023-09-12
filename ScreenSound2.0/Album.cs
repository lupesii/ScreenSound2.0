class Album
{
    private List<Musica> Musicas = new List<Musica>();
    public string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}