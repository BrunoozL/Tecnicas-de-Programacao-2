Console.WriteLine("Café da manhã");
CafeDaManha();
Console.ReadKey();

static async void CafeDaManha()
{
    Console.WriteLine("\nPreparar o café:");
    var Taskcafe = PrepararCafe();
    Console.WriteLine("\nPreparar o pão:");
    var Taskpao = PrepararPao();
    var cafe = await (Taskcafe);
    var pao = await (Taskpao);
    ServirCafe(cafe, pao);
}

static async Task<Cafe> PrepararCafe()
{
    Console.WriteLine("Ferver a água");
    await Task.Delay(2000);
    Console.WriteLine("Coando o café");
    await Task.Delay(2000);
    return new Cafe();
}

static async Task<Pao> PrepararPao()
{
    Console.WriteLine("Partir o pão");
    await Task.Delay(2000);
    Console.WriteLine("Passar manteiga no pão");
    await Task.Delay(2000);
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