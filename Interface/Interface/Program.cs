IAnimal gato = new Gato();
IAnimal cachorro = new Cachorro();

Console.WriteLine(gato.FazerSom());
Console.WriteLine("-------------------");
Console.WriteLine(cachorro.FazerSom());

public interface IAnimal
{
    public string FazerSom();
}

public class Gato : IAnimal
{
    public string FazerSom()
    {
        return "Miau";
    }
}

public class Cachorro : IAnimal
{
    public string FazerSom()
    {
        return "Au au";
    }
}