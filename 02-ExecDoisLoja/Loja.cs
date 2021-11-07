using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExecDoisLoja
{
    public class Loja
    {
        Livro livro = new Livro();
        VideoGame videoGame = new VideoGame();

        private string Nome { get; set; }
        private string Cnpj { get; set; }
        private List<Livro> Livros { get; set; }
        private List<VideoGame> VideoGames { get; set; }

        public Loja()
        {}

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }

        public void ListaLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum Livro Cadastrado!");
                return;
            }
            foreach(var livro in Livros)
            {
                Console.WriteLine($"Livro: {livro.RetornaTitulo()}, Preço: R$ {livro.RetornaPreco().ToString("F2", CultureInfo.InvariantCulture)}, Quantidade em Estoque: {livro.RetornaQuantidade()} ");
            }
        }

        public void ListaVideoGames()
        {
            if (VideoGames.Count == 0)
            {
                Console.WriteLine("Nenhum Video Games Cadastrado!");
            }
            foreach(var videoGame in VideoGames)
            {
                Console.WriteLine($"Video Game: {videoGame.RetornaNome()}, Preço: R$ {videoGame.RetornaPreco().ToString("F2", CultureInfo.InvariantCulture)}, Quantidade em Estoque: {videoGame.RetornaQuantidade()}");
            }
        }        

        public double CalculaPatrimonio()
        {
            double livro1 = Livros[0].RetornaPreco() * Livros[0].RetornaQuantidade();
            double livro2 = Livros[1].RetornaPreco() * Livros[1].RetornaQuantidade();
            double livro3 = Livros[2].RetornaPreco() * Livros[2].RetornaQuantidade();

            double totalLivros = livro1 + livro2 + livro3;

            double videoGame1 = VideoGames[0].RetornaPreco() * VideoGames[0].RetornaQuantidade();
            double videoGame2 = VideoGames[1].RetornaPreco() * VideoGames[1].RetornaQuantidade();
            double videoGame3 = VideoGames[2].RetornaPreco() * VideoGames[2].RetornaQuantidade();

            double totalVideoGame = videoGame1 + videoGame2 + videoGame3;        
            
            double valorTotal;
            valorTotal = totalLivros + totalVideoGame;

            Console.WriteLine("Patrimonio da Loja " + Nome + ": R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            return valorTotal;
        }
    }
}