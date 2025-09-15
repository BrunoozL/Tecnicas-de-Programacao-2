using System.ComponentModel;

// OBS: a criação da classe vem abaixo da instância.

Professor prof = new Professor("Vânia", "(14) 99999-9999", "Mestre");
Console.WriteLine($"Nome: {prof.Nome}\nCelular: {prof.Celular}\nTitulação: {prof.Titulacao}");

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string? Celular { get; set; }

    public Pessoa(string nome, string? celular)
    {
        Nome = nome;
        Celular = celular;
    }
}

class Professor: Pessoa
{
    public string? Titulacao { get; set; }

    public Professor(string nome, string celular, string titulacao): base(nome, celular) // base() para referenciar os atributos da classe pai
    {
        Titulacao = titulacao;
    }
}