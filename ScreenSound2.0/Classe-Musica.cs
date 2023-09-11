class Musica
{
    public string artista;
    public string nome;
    public int duracao;
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
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
        Console.WriteLine($"Nome/Artista: {nome}/{artista}");
    }
}