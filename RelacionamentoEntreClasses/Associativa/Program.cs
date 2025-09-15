Filme filme1 = new Filme("A Dama e o Vagabundo", 1955);
Ator ator1 = new Ator("Barbara Luddy");
Ator ator2 = new Ator("Larry Roberts");
Atuacao atuacao1 = new Atuacao("Dama", ator1, filme1);
Atuacao atuacao2 = new Atuacao("Vagabundo", ator2, filme1);

Console.WriteLine($"Filme: {atuacao1.AtuacaoFilme.Titulo} - {atuacao1.AtuacaoFilme.Ano}");
Console.WriteLine($"Ator: {atuacao1.AtuacaoAtor.Nome}");
Console.WriteLine($"Papel: {atuacao1.Papel}");

Console.ReadKey();

class Filme
{
    public string? Titulo { get; set; }
    public int? Ano { get; set; }

    public Filme(string titulo, int ano)
    {
        Titulo = titulo;
        Ano = ano;
    }
}

class Ator
{
    public string? Nome { get; set; }

    public Ator(string nome)
    {
        Nome = nome;
    }
}

class Atuacao
{
    public string? Papel { get; set; }
    public Ator? AtuacaoAtor { get; set; }
    public Filme? AtuacaoFilme { get; set; }

    public Atuacao(string papel, Ator atuacaoAtor, Filme atuacaoFilme)
    {
        Papel = papel;
        AtuacaoAtor = atuacaoAtor;
        AtuacaoFilme = atuacaoFilme;
    }
}