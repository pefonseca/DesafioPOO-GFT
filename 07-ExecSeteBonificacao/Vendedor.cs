namespace ExecSeteBonificacao
{
    public class Vendedor : Funcionario
    {
        public override void Bonificacao()
        {
            Salario += 3000;
        }
    }
}