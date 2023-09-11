class Musica
{
    public string artista;
    public string nome;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    public bool LeDisponivel()
    {
        return disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
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