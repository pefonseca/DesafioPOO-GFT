using System;
using System.Collections.Generic;

namespace ExecTresPersonagem
{
    public class Mago : Personagem
    {
        List<string> Magia = new List<string>();

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        public override void LevelUp()
        {
            Vida++;
            Mana = Mana + 2;
            Xp++;            
            Inteligencia = Inteligencia + 2;
            Forca++;
            Level++;

            Console.WriteLine("O Mago subiu de nivel\nSeus novos dados:");
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
            var ataque = Inteligencia * Level;
            Random num = new Random();
            int numAleatorio = num.Next(1, 300);

            var ataqueFinal = ataque + numAleatorio;

            Console.WriteLine("Ataque do Mago é: " + ataqueFinal);
        }

        public void AprenderMagia(string valor)
        {

        }

        public void MostrarDados()
        {
            Console.WriteLine("Mago: " + Nome);
            Console.WriteLine("Vida: " + Vida);
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Xp: " + Xp);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Forca: " + Forca);
            Console.WriteLine("Level: " + Level);
        }        
    }
}