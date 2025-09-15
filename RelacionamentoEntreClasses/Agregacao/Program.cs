Categoria cat1 = new Categoria("Material Escolar");

Produto prod1 = new Produto("Lapiseira", 12.99, cat1);
Produto prod2 = new Produto("Borracha", 4.99, cat1);

// Método Mostrar() é estático, por isso é chamado pelo Classe.Método
Produto.Mostrar(prod1);
Produto.Mostrar(prod2);

class Produto
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public Categoria CategoriaProduto { get; set; }

    public Produto(string nome, double preco, Categoria categoria)
    {
        Nome = nome;
        Preco = preco;
        CategoriaProduto = categoria;
    }

    public static void Mostrar(Produto prod)
    {
        Console.WriteLine($"Nome: {prod.Nome} - Preço: {prod.Preco} - Categoria: {prod.CategoriaProduto.Descritivo}");
    }
}

class Categoria
{
    public string? Descritivo { get; set; }

    public Categoria(string descritivo)
    {
        Descritivo = descritivo;
    }
}