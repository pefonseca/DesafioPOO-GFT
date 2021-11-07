using System;
using System.Globalization;

namespace ExecDoisLoja
{
    public class VideoGame : Produto, IImposto
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private bool IsUsado { get; set; }

        public VideoGame()
        {}

        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool isUsado) : base(nome, preco, quantidade)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public string RetornaNome()
        {
            return Nome;
        }

        public double RetornaPreco()
        {
            return Preco;
        }

        public int RetornaQuantidade()
        {
            return Quantidade;
        }

        public void CalculaImposto()
        {
            if (IsUsado == true)
            {
                double valor = 0.25;
                double calculoImposto = Preco * valor;
                double valorFinal = Preco + calculoImposto;
                Console.WriteLine("Valor do produto com imposto: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                double valor = 0.45;
                double calculoImposto = Preco * valor;
                double valorFinal = Preco + calculoImposto;
                Console.WriteLine("Valor do produto com imposto: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}