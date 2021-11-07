namespace ExecDoisLoja
{
    public abstract class Produto
    {
        protected string Nome { get; set; }
        protected double Preco { get; set; }
        protected int Quantidade { get; set; }

        public Produto()
        {}

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}