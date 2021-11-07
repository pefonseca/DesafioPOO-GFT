using System;
using System.Globalization;

namespace ExecDoisLoja
{
    public class Livro : Produto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QuantidadePage { get; set; }

        public Livro()
        {}

        public Livro(string nome, double preco, int quantidade, string autor, string tema, int quantidadePage) : base(nome, preco, quantidade)
        {
            Autor = autor;
            Tema = tema;
            QuantidadePage = quantidadePage;
        } 

        public string RetornaTitulo()
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
            if(Tema.ToLower() != "educativo")
            {                
                double valor = 0.10;
                double calculoImposto = Preco * valor;
                double valorFinal = Preco + calculoImposto;
                Console.WriteLine("Valor do produto com imposto: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Produto de tema Educativo, não tem imposto sobre!");
            }
        }
    }
}