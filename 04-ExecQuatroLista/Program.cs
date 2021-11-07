using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ExecQuatroLista
{
    class Program
    { 
        static List<Pessoa> lista;
        static void Main(string[] args)
        {
            lista = new List<Pessoa>();

            lista.Add(new Pessoa("João", 10));
            lista.Add(new Pessoa("Leandro", 20));
            lista.Add(new Pessoa("Paulo", 10));
            lista.Add(new Pessoa("Jessica", 40));  

            Console.WriteLine("Lista de Usuários:\n");

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Nome + " tem " + lista[i].Idade + " anos de idade.");
            }

            Console.WriteLine("\nPessoa mais velha tem " + lista.Max(x => x.Idade + " anos e se chama " + x.Nome));            
        }
    }
}
