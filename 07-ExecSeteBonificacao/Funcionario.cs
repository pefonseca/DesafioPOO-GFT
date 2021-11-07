namespace ExecSeteBonificacao
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public abstract void Bonificacao();
    }
}