class Musica
{
    public string Artista {  get; set; }
    public string Nome {  get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string Descricao 
    {
        get
        {
            return $"A música {Nome} foi feita pela banda {Artista}";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Ultra");
        }
    }

    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome}/{Artista}");
    }
}