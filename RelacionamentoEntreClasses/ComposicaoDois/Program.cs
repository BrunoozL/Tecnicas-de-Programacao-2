Pessoa pes1 = new Pessoa("Bruno", 14, "999999999");

Pessoa.Exibir(pes1);

Pessoa pes2 = new Pessoa("Matheus");
Celular cel1 = new Celular(14, "988888888", pes2);

Pessoa.Exibir(pes2);

class Pessoa
{
    public string? Nome { get; set; }
    public List<Celular> Celular = new List<Celular>{};

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, int ddd, string numero)
    {
        Nome = nome;
        Celular.Add(new Celular(ddd, numero));
    }

    public void setCelular(int ddd, string numero)
    {
        Celular.Add(new global::Celular(ddd, numero));
    }

    public static void Exibir(Pessoa pessoa)
    {
        Console.WriteLine($"Nome: {pessoa.Nome} - DDD: {pessoa}");
    }
}

class Celular
{
    public int DDD { get; set; }
    public string? Numero { get; set; }
    public Pessoa PessoaCelular { get; set; }

    public Celular(int ddd, string numero)
    {
        DDD = ddd;
        Numero = numero;
    }

    public Celular(int ddd, string numero, Pessoa pessoaCelular)
    {
        DDD = ddd;
        Numero = numero;
        PessoaCelular = pessoaCelular;
    }
}