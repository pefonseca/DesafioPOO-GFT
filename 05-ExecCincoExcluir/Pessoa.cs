namespace ExecCincoExcluir
{
    public class Pessoa
    {
        public Pessoa() 
        {}

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;
        }

    }
}