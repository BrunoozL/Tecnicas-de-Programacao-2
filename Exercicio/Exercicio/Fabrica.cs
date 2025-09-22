using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Fabrica
    {
        public string? Nome {  get; set; }
        public static ICollection<Maquina>? MaquinasFabrica { get; set; } = new List<Maquina>();

        public Fabrica(string nome, string modeloMaquina, string horaOperacaoMaquina, string observacaoMaquina, string nomeMaquina, DateTime dataFabricacaoMaquina)
        {
            Nome = nome;
            MaquinasFabrica.Add(new Maquina(modeloMaquina, horaOperacaoMaquina, observacaoMaquina, nomeMaquina, dataFabricacaoMaquina));
        }

        public void AdicionarMaquinas(string modeloMaquina, string horaOperacaoMaquina, string observacaoMaquina, string nomeMaquina, DateTime dataFabricacaoMaquina)
        {
            MaquinasFabrica.Add(new Maquina(modeloMaquina, horaOperacaoMaquina, observacaoMaquina, nomeMaquina, dataFabricacaoMaquina));
        }
        public void ListarMaquinas(Maquina maquina)
        {
            Console.WriteLine($"Nome: {maquina.Nome}");
            Console.WriteLine($"Modelo: {maquina.Modelo}");
            Console.WriteLine($"Data de Fabricação: {maquina.DataFabricacao}");
            Console.WriteLine($"Número de Série: {maquina.NumeroSerie}");
        }
        public Maquina? BuscarMaquinaPorModelo(string modelo)
        {
            foreach(var maquina in MaquinasFabrica)
            {
                if(maquina.Modelo == modelo)
                {
                    return maquina;
                }
            }
            return null;
        }
    }
}
