class Equipe
{
    private string nome;
    private string pais;
    private int anoFundacao;

    public Equipe(string nome, string pais, int anoFundacao)
    {
        this.nome = nome;
        this.pais = pais;
        this.anoFundacao = anoFundacao;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Pais
    {
        get { return pais; }
        set { pais = value; }
    }

    public int AnoFundacao
    {
        get { return anoFundacao; }
        set { anoFundacao = value; }
    }

    // Método 1
    public void MostrarInformacoes()
    {
        Console.WriteLine($"A equipe {nome} é do país {pais} e foi fundada em {anoFundacao}.");
    }

    // Método 2
    public bool EhAntiga()
    {
        return anoFundacao < 2000;
    }

    // Método 3
    public void AlterarPais(string novoPais)
    {
        pais = novoPais;
    }

    public override string ToString()
    {
        return $"Nome: {nome}, País: {pais}, Ano de Fundação: {anoFundacao}";
    }
}
