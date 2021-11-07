using System;

namespace ExecTresPersonagem
{
    public class Personagem
    {
        protected string Nome { get; set; }
        protected int Vida { get; set; }
        protected int Mana { get; set; }
        protected float Xp { get; set; }
        protected int Inteligencia { get; set; }
        protected int Forca { get; set; }
        protected int Level { get; set; }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public virtual void LevelUp()
        {

        }
    }
}