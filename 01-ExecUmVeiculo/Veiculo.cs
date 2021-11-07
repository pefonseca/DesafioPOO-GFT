using System;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace ExecUmVeiculo
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private float Km { get; set; }
        private bool IsLigado { get; set; }
        private int LitrosCombustivel { get; set; }
        private int Velocidade { get; set; }
        private double Preco { get; set; }

        private static int opcao = 0;

        public void MostrarDados()
        {
            Console.Write("Informe a Marca do Carro: ");
            Marca = Console.ReadLine();
            Console.Write("Informe o Modelo do Carro: ");
            Modelo = Console.ReadLine();
            
            var letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numeros = "0123456789";
            var random = new Random();
            var varLetras = new string(Enumerable.Repeat(letras, 3).Select(s => s[random.Next(s.Length)]).ToArray());
            var varNumeros = new string(Enumerable.Repeat(numeros, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            Placa = varLetras + "-" + varNumeros;          

            Console.WriteLine("Placa do Carro: " + Placa);

            Cor = "Preto";

            Console.Write("Informe o Preço do carro: ");
            Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Informações do seu Carro: ");
            Console.WriteLine("Marca do Carro: " + Marca);
            Console.WriteLine("Modelo do Carro: " + Modelo);
            Console.WriteLine("Placa do Carro: " + Placa);
            Console.WriteLine("Cor padrão do Carro: " + Cor);
            Console.WriteLine("Preço do Carro: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n-------------------------------------\n");
        }

        public void InfoCarro()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine("Informações do seu Carro: ");
            Console.WriteLine("Marca do Carro: " + Marca);
            Console.WriteLine("Modelo do Carro: " + Modelo);
            Console.WriteLine("Placa do Carro: " + Placa);
            Console.WriteLine("Cor padrão do Carro: " + Cor);
            Console.WriteLine("Preço do Carro: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n-------------------------------------\n");

            TestarFuncoes();
        }

        public void TestarFuncoes()
        {
            Console.WriteLine("Teste as funções do carro!");
            Console.WriteLine("\nSelecione uma função: ");

            Console.WriteLine("\n1 - Acelerar");
            Console.WriteLine("2 - Abastecer");
            Console.WriteLine("3 - Frear");
            Console.WriteLine("4 - Pintar");
            Console.WriteLine("5 - Ligar");
            Console.WriteLine("6 - Desligar");
            Console.WriteLine("7 - Informações do Carro");
            Console.WriteLine("8 - Sair\n");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Acelerar();
                    break;
                case 2:
                    Abastecer(0);
                    break;
                case 3:
                    Frear();
                    break;
                case 4:
                    Pintar("Preto");
                    break;
                case 5:
                    Ligar();
                    break;
                case 6:
                    Desligar();
                    break;
                case 7:
                    InfoCarro();
                    break;
                case 8:
                    break;
            }
        }

        public void Acelerar()
        {
            if(IsLigado == true)
            {                
                Velocidade += 20;
                Console.WriteLine("Velocidade acrescentada: " + Velocidade + " KM/h");
            }
            else
            {
                Console.WriteLine("Ligue o carro para acelerar!");
            }

            TestarFuncoes();
        }

        public void Abastecer(int Combustivel)
        {
            Console.WriteLine("\nInforme a quantidade de combustivel que deseja abastercer: ");
            Combustivel = int.Parse(Console.ReadLine());
            
            LitrosCombustivel += Combustivel;
            
            if(LitrosCombustivel > 60)
            {
                Console.WriteLine("Não pode ser abastecido, pois o valor é superior a capacidade do tanque, que é 60 litros!");
            }
            else 
            {                
                Console.WriteLine("Quantidade abastecida: " + Combustivel + " Litros");
                Console.WriteLine("Quantidade no tanque: " + LitrosCombustivel + " Litros\n");
            }

            TestarFuncoes();
        }

        public void Frear()
        {
            if (IsLigado == true)
            {          
                if (Velocidade == 0)
                {
                    Console.WriteLine("Seu carro está parado, não pode freiar mais!");
                }
                else
                {                    
                    Velocidade -= 20;
                    Console.WriteLine("Você freio, sua velocidade é: " + Velocidade + " KM/h");
                }
            }
            else 
            {
                Console.WriteLine("Veiculo está desligado, ligue ele e acelere para freiar!");
            }

            TestarFuncoes();
        }

        public void Pintar(string Cor)
        {
            Console.WriteLine("Deseja mudar a cor do seu carro?\n1 - Sim\n2 - Não");
            int Valor = int.Parse(Console.ReadLine());
            if (Valor == 1)
            {
                Console.WriteLine("Insira a nova cor do carro: ");
                Cor = Console.ReadLine();

                Console.WriteLine($"\nA nova cor do carro é {Cor}!");
            }
            else if(Valor == 2)
            {
                Console.WriteLine("Cor não alterada");
            }

            TestarFuncoes();
        }

        public void Ligar()
        {
            if(IsLigado == false)
            {
                Console.WriteLine("Deseja ligar o carro? \n1 - Sim\n2 - Não");
                int Valor = int.Parse(Console.ReadLine());
                if (Valor == 1)
                {
                    Console.WriteLine("O carro está ligando, aguarde!");
                    Thread.Sleep(1000);
                    Console.WriteLine("3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1...");
                    Console.WriteLine("\nCarro ligado!");
                    IsLigado = true;
                }
                else 
                {
                    Console.WriteLine("Ok!");
                }
            }
            else
            {
                Console.WriteLine("Carro já está Ligado!");
            }

            TestarFuncoes();
        }

        public void Desligar()
        {
            if (Velocidade > 0)
            {   
                Console.WriteLine("Carro está em movimento não pode ser desligado, pare o carro!");            
            }
            else
            {   
                if (IsLigado == true)
                {
                    Console.WriteLine("O carro está Desligando, aguarde!");
                    Thread.Sleep(1000);
                    Console.WriteLine("3...");
                    Thread.Sleep(1000);
                    Console.WriteLine("2...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1...");
                    Console.WriteLine("\nCarro Desligado!");
                    IsLigado = false;
                }
                else
                {
                    Console.WriteLine("Carro já está desligado!");
                }
            }

            TestarFuncoes();
        }
    }
}