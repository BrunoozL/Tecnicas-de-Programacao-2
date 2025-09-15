using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Operador
    {
        public string? Nome {  get; set; }
        public Maquina? MaquinaOperador { get; set; }

        public Operador(string nome, Maquina maquinaOperador)
        {
            Nome = nome;
            MaquinaOperador = maquinaOperador;
        }

        public async static void OperarMaquinaAsync(Fabrica fabrica, string modelo)
        {
            Console.WriteLine($"{} está tentando operar a máquina modelo {}");
            await Task.Delay(2000);
        }
    }
}
