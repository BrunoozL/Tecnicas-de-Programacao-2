// ArrayList
using System.Collections;

ArrayList lista1 = new ArrayList() { "Bruno", 19, 1.68, true };
ExibirArrayList(lista1);
var lista2 = new ArrayList();
ArrayList lista3 = new(5);

lista1.Add("sim.");
ExibirArrayList(lista1);
lista1.Insert(1, "perdido");
ExibirArrayList(lista1);
lista1.RemoveAt(4);
ExibirArrayList(lista1);

string[] cores = new string[3] { "Castanho", "Verdes", "Azul" };

lista1.AddRange(cores);
lista1.InsertRange(0, cores);
ExibirArrayList(lista1);

lista1.Clear();
ExibirArrayList(lista1);

// Mostrar elementos do ArrayList
static void ExibirArrayList(ArrayList lista1)
{
    foreach(var elemento in lista1)
    {
        Console.WriteLine(elemento);
    }
    Console.WriteLine("------------------------------");
}