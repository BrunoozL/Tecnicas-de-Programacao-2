// Formas de atribuir valor aos atributos:

// Forma 1
Produto prod = new Produto();
prod.Nome = "Caderno";
prod.Preco = 19.99;

// Forma 2
Fornecedor forn1 = new Fornecedor("Faber Castell", "1111111111111");
Fornecedor forn2 = new Fornecedor("Foroni", "22222222222222");

prod.Fornecedores = new List<Fornecedor>();
prod.Fornecedores.Add(forn1);
prod.Fornecedores.Add(forn2);

// Mostrando o objeto produto
Console.WriteLine("======= PRODUTO =======");
Console.WriteLine($"Nome: {prod.Nome}\nPreco: {prod.Preco}");
Console.WriteLine("=========================");
Console.WriteLine("FORNECEDORES: ");
var x = 1;
foreach(var fornecedor in prod.Fornecedores)
{
    Console.WriteLine($"{x}° FORNECEDOR -> Razão Social: {fornecedor.RazaoSocial} - CNPJ: {fornecedor.Cnpj}");
    x++;
}

Console.ReadKey();
Console.WriteLine();

// Mostrando o objeto fornecedor 3
Fornecedor forn3 = new Fornecedor("Tilibra", "333333333333333", new Produto("Lápis", 7.99));
Console.WriteLine("======= FORNECEDOR =======");
Console.WriteLine($"Razão Social: {forn3.RazaoSocial}\nCNPJ: {forn3.Cnpj}\nProduto -> Nome: {forn3.Produto.Nome} - Preço: {forn3.Produto.Preco}");

Console.ReadKey();

class Produto
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public List<Fornecedor>? Fornecedores { get; set; }

    public Produto(){}

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

class Fornecedor
{
    public string? RazaoSocial { get; set; }
    public string? Cnpj { get; set; }
    public Produto? Produto { get; set; }

    public Fornecedor(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
    }

    public Fornecedor(string razaoSocial, string cnpj, Produto produto)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
        Produto = produto;
    }
}