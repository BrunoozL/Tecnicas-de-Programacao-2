using System.Data.SqlTypes;

ICollection<string> nomes1 = new List<string> { "Maria", "Amanda" };
nomes1.Add("Clara");
Exibir(nomes1);
Console.WriteLine("----------------");
nomes1.Remove("Maria");
Exibir(nomes1);
Console.WriteLine(nomes1.Count());

/* Interface genérica com mecânismos para
 * percorrer coleções usando foreach */
void Exibir(ICollection<string> colecao)
{
    foreach (var nome in colecao)
    {
        Console.Write($"{nome}\n");
    }
}