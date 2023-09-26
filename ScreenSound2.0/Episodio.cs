class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<String> Convidados = new List<String>();
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    public void AdicionarConvidados(String convidado)
    {
        Convidados.Add(convidado);
    }
}