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

    public override string ToString()
    {
        return $"Nome: {nome}, País: {pais}, Ano de Fundação: {anoFundacao}";
    }
}
