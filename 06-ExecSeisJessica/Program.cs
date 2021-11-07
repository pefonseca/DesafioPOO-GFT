using System;
using System.Collections.Generic;

namespace ExecSeisJessica
{
    class Program
    {
        static List<Pessoa> lista;
        static void Main(string[] args)
        {
            lista = new List<Pessoa>();

            lista.Add(new Pessoa("Leandro", 20));
            lista.Add(new Pessoa("Jessica", 40));      

            RemovendoJessica();
        }

        static void RemovendoJessica()
        {
            List<Pessoa> removendoJessica = lista.FindAll(delegate (Pessoa pessoa) { return pessoa.Nome != "Jessica"; });
            Console.WriteLine("\nLista sem Jéssica: ");
            removendoJessica.ForEach(delegate (Pessoa pessoa)
            {
                Console.WriteLine(String.Format(pessoa.Nome + " tem " + pessoa.Idade + " anos de idade!"));
            });
        }
    }
}
