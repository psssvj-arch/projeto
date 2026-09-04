class Moto
{
    private string modelo;
    private string marca;
    private int ano;

    public Moto(string modelo, string marca, int ano)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.ano = ano;
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    public override string ToString()
    {
        return $"Modelo: {modelo}, Marca: {marca}, Ano: {ano}";
    }
}
