// Na composição, o objeto motor é instânciado dentro da classe Carro

// "V6" e "300cv" são do atributo MotorCarro
Carro carro = new Carro("BMW", "M4", "V6", "300cv");
Console.WriteLine($"Marca: {carro.Marca} - Modelo: {carro.Modelo}\nMotor -> Tipo: {carro.MotorCarro.Tipo} - Potência: {carro.MotorCarro.Potencia}");

class Carro
{
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public Motor MotorCarro { get; set; }

    public Carro(string marca, string modelo, string tipo, string potencia)
    {
        Marca = marca;
        Modelo = modelo;
        MotorCarro = new Motor(tipo, potencia);
    }
}

class Motor
{
    public string? Tipo { get; set; }
    public string? Potencia { get; set; }

    public Motor(string tipo, string potencia)
    {
        Tipo = tipo;
        Potencia = potencia;
    }
}