using System;

namespace ExecTresPersonagem
{
    static class Program
    {
        static void Main(string[] args)
        {
            Mago mago = new Mago("Dr. Estranho", 10, 10, 0, 10, 10, 0);

            Guerreiro guerreiro = new Guerreiro("Thor", 10, 10, 0, 10, 10, 0);

            Console.WriteLine("");
            mago.MostrarDados();
            Console.WriteLine("");
            guerreiro.MostrarDados();
            Console.WriteLine("");

            mago.Attack();
            guerreiro.Attack();

            Console.WriteLine("");

            mago.LevelUp();
            guerreiro.LevelUp();            
        }
    }
}
