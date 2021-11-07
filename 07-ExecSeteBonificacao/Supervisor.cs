namespace ExecSeteBonificacao
{
    public class Supervisor : Funcionario
    {
        public override void Bonificacao()
        {
            Salario += 5000;
        }
    }
}