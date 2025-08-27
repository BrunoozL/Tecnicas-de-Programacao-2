// List
using System.Runtime.CompilerServices;

List <string> nomes = new List <string>() { "Bruno", "Ana", "Roberto", "Maria" };

nomes.Add("Felipe");
nomes.Insert(2, "Rodrigo");
nomes.Sort();

// Find(Predicado), FindLast, FindIndex, FindLastIndex, FindAll
// Predicado é uma função ou método de argumento único que retorna um valor booleano
var selecionados1 = nomes.Find(Procurar);
Console.WriteLine(selecionados1);
Console.WriteLine("---------------------------");

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("---------------------------");

static bool Procurar(string item)
{
    //return item.Contains("B");
    return item.StartsWith("A");
}

// Expressão Lambda: é uma função anônima
var resultado1 = nomes.Find(i => i.Contains('o'));
Console.WriteLine(resultado1);
Console.WriteLine("---------------------------");

var resultado2 = nomes.FindAll(i => i.StartsWith("A"));
foreach(var nome in resultado2)
{
    Console.WriteLine(nome);
}
Console.WriteLine("---------------------------");

var resultado3 = nomes.FindLast(i => i.Contains("a"));
Console.WriteLine(resultado3);
Console.WriteLine("---------------------------");

var resultado4 = nomes.FindIndex(i => i.Contains("a"));
Console.WriteLine(resultado4);
Console.WriteLine("---------------------------");
