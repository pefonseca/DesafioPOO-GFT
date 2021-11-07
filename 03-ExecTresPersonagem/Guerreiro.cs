using System;
using System.Collections.Generic;

namespace ExecTresPersonagem
{
    public class Guerreiro : Personagem
    {
        List<string> Habilidade = new List<string>();

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        public override void LevelUp()
        {
            Vida = Vida + 2;
            Mana++;
            Xp++;            
            Inteligencia++;
            Forca = Forca + 2;
            Level++;

            Console.WriteLine("O Guerreiro subiu de nivel\nSeus novos dados:");
            Console.WriteLine("");
            Console.WriteLine("Guerreiro: " + Nome);
            Console.WriteLine("Vida: " + Vida);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Xp: " + Xp);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Forca: " + Forca);
            Console.WriteLine("Level: " + Level);
        }

        public void Attack()
        {
            var ataque = Forca * Level;
            Random num = new Random();
            int numAleatorio = num.Next(1, 300);

            var ataqueFinal = ataque + numAleatorio;

            Console.WriteLine("Ataque do Guerreiro é: " + ataqueFinal);
        }

        public void AprenderHabilidade(string valor)
        {
            
        }

        public void MostrarDados()
        {
            Console.WriteLine("Guerreiro: " + Nome);
            Console.WriteLine("Vida: " + Vida);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Xp: " + Xp);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Forca: " + Forca);
            Console.WriteLine("Level: " + Level);
        }
    }
}