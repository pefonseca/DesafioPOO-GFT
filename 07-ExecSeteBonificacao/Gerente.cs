namespace ExecSeteBonificacao
{
    public class Gerente : Funcionario
    {
        public override void Bonificacao()
        {
            Salario += 10000;
        }
    }
}