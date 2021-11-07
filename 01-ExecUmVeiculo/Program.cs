using System;

namespace ExecUmVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            veiculo.MostrarDados();
            
            veiculo.TestarFuncoes();
        }
    }
}
