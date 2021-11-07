using System;
using System.Collections.Generic;
using System.Linq;

namespace ExecCincoExcluir
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

            ListaSemMenor();              
        }

        static void ListaSemMenor()
        {
            List<Pessoa> semMenor = lista.FindAll(delegate (Pessoa pessoa) { return pessoa.Idade > 19; });
            Console.WriteLine("\nLista sem menor de idade: ");
            semMenor.ForEach(delegate (Pessoa pessoa)
            {
                Console.WriteLine(String.Format(pessoa.Nome + " " + pessoa.Idade + " anos de idade!"));
            });
        }
    }
}
