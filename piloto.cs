class Piloto
{
    private string nome;
    private int idade;
    private string equipe;

    public Piloto(string nome, int idade, string equipe)
    {
        this.nome = nome;
        this.idade = idade;
        this.equipe = equipe;
    }
    
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public string Equipe
    {
        get { return equipe; }
        set { equipe = value; }
    }
    public override string ToString()
    {
        return $"Nome: {nome}, Idade: {idade}, Equipe: {equipe}";
    }
}