using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Maquina : Equipamento
    {
        public string? Modelo { get; set; }
        public string? HoraOperacao { get; set; }

        private Guid numeroSerie;
        public Guid? NumeroSerie
        {
            get { return numeroSerie; } 
        }

        private string? obs;
        public string Observacao
        {
            set { obs = value; }
        }

        public Maquina(string modelo, string horaOperacao, string observacao, string nome, DateTime dataFabricacao): base(nome, dataFabricacao)
        {
            Modelo = modelo;
            HoraOperacao = horaOperacao;
            Observacao = observacao;
            Nome = nome;
            DataFabricacao = dataFabricacao;
        }
    }
}
