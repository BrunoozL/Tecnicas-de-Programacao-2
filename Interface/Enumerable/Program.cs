using System.Data.SqlTypes;

List<string> nomes1 = new List<string> { "Maria", "Amanda" };
string[] nomes2 = { "Felipe", "Bruno" };
Exibir(nomes1);
Console.WriteLine("----------------");
Exibir(nomes2);

/* Interface genérica com mecânismos para
 * percorrer coleções usando foreach */
void Exibir(IEnumerable<string>colecao)
{
    foreach(var nome in colecao)
    {
        Console.Write($"{nome}\n");
    }
}