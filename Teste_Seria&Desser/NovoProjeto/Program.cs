using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
var caminho = "pessoas.json";

List<Pessoa> listaPessoas = new List<Pessoa>
{
    new Pessoa { Nome = "Nathalia", Idade = 19 },
    new Pessoa { Nome = "Ana Clara", Idade = 19 },
    new Pessoa { Nome = "Bruno", Idade = 20 },
};

// Serialização em arquivo
if(!File.Exists(caminho))
{
    string jsonString = JsonSerializer.Serialize(listaPessoas, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(caminho, jsonString);
    Console.WriteLine("Arquivo em JSON gravado!");
}

// Desserialização 
if(File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
    List<Pessoa> listaConteudo = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);
    Console.WriteLine("===== LISTA DE PESSOAS =====");
    foreach (var pessoa in listaConteudo)
    {
        Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}");
    }
}

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa() { }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}