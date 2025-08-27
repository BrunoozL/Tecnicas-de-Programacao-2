// Formas de instanciar
Produto p1 = new Produto("Caderno", 29.99, 50);
Produto p2 = new ("Lápis preto");
var p3 = new Produto();
Console.WriteLine($"{p2.Nome}\n{p2.PrecoFinal}");
Console.WriteLine("------------------------");
Console.WriteLine(p3.Preco);
Console.WriteLine("------------------------");

// p1.Nome = "Caderno";
// p1.Preco = 29.99;
// p1.Desconto = 5; /* Não funciona mais, pois é somente leitura */
// p1.PrecoFinal = p1.Preco - (p1.Preco * p1.Desconto / 100); /* Não funciona mais, pois é somente leitura */
// p1.EstoqueMinimo = 50;

p1.Exibir();

Console.ReadKey();
public class Produto
{
    // Métodos construtor:
    public Produto(string nome, double Preco, int minimo)
    {
        Nome = nome; // Atributo e parâmetro com grafia DIFERENTE
        this.Preco = Preco; // Atributo e parâmetro com grafia IGUAL, precisamos usar o this para referenciar o atributo
        EstoqueMinimo = minimo;
    }
    public Produto(){} // Construtor vazio
    public Produto(string nome)
    {
        Nome = nome;        
    }

    // Propriedade de leitura e gravação, modificado na leitura
    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); }
        set {  nome = value; } 
    }

    // Propriedade de leitura e gravação, modificado na gravação
    private double preco;
    public double Preco 
    {
        get { return preco; } 
        set
        {
            if(value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        }
    }

    // Propriedade apenas de leitura já atribuindo um valor
    private int desconto = 5;
    public int Desconto 
    { 
        get { return desconto; }
    }

    // Propriedade apenas de leitura
    public double PrecoFinal 
    { 
        get { return Preco - (Preco * Desconto / 100); }
    }

    // Propriedade apenas de gravação
    private int minimo;
    public int EstoqueMinimo 
    { 
        set {  minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}\n" +
            $"Preço: {Preco.ToString("c")}\n" +
            $"Desconto: {Desconto}%\n" +
            $"Preço Final: {PrecoFinal.ToString("c")}\n" +
            $"Estoque: {minimo}");
    }
}