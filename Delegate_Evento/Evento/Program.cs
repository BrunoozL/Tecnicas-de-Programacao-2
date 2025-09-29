Console.WriteLine("Iniciando o Pedido");
Pedido pedido = new Pedido();

// Registra os assinantes
pedido.OnCriarPedido += EnviarEmail.Email;
pedido.OnCriarPedido += EnviarSMS.SMS;

// Criar o pedido
pedido.CriarPedido();
Console.WriteLine("Finalizando o pedido");

Console.ReadKey();

public delegate void PedidoEvent();

class Pedido
{
    public event PedidoEvent? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Pedido sendo criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class EnviarEmail
{
    public static void Email()
    {
        Console.WriteLine("Email enviado");
    }
}

class EnviarSMS
{
    public static void SMS()
    {
        Console.WriteLine("SMS enviado");
    }
}