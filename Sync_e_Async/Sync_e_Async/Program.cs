Console.WriteLine("Café da manhã");
CafeDaManha();
Console.ReadKey();

static void CafeDaManha()
{
    Console.WriteLine("\nPreparar o café:");
    var cafe = PrepararCafe();
    Console.WriteLine("\nPreparar o pão:");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);
}

static Cafe PrepararCafe()
{
    Console.WriteLine("Ferver a água");
    Thread.Sleep(2000);
    Console.WriteLine("Coando o café");
    Thread.Sleep(2500);
    return new Cafe();
}

static Pao PrepararPao()
{
    Console.WriteLine("Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("Passar manteiga no pão");
    Thread.Sleep(2000);
    Console.WriteLine("Tostar o pão");
    return new Pao();
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo o café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("Café servido");
}

internal class Cafe()
{
}
internal class Pao()
{
}