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

        public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
        {
            Console.WriteLine($"{this.Nome} está tentando operar a máquina modelo {modelo}");
            await Task.Delay(2000);

            var retorno = fabrica.BuscarMaquinaPorModelo(modelo);

            if(retorno == null)
            {
                Console.WriteLine($"Máquina modelo {modelo} não encontrada");
            }
            else
            {
                Console.WriteLine($"{this.Nome} está operando a máquina modelo {modelo}");
                Task.Delay(2000);

            }
        }
    }
}
