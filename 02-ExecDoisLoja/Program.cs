using System;
using System.Collections.Generic;

namespace ExecDoisLoja
{
    class Program 
    {
        static void Main(string[] args)
        {

            Livro livro1 = new Livro("Harry Potter", 300, 30, "J. K. Rowling", "Fantasia", 1000);
            Livro livro2 = new Livro("Chapéuzinho Vermelho", 200, 20, "Joãozinho", "Educativo", 100);
            Livro livro3 = new Livro("Os 3 Porquinhos", 100, 10, "Mariazinha", "Infantil", 1000);

            List<Livro> livros = new List<Livro>();
            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);

            VideoGame videoGame1 = new VideoGame("PS5", 5000, 100, "Sony", "Slim", false);
            VideoGame videoGame2 = new VideoGame("PS4", 1500, 50, "Sony", "Slim", true);
            VideoGame videoGame3 = new VideoGame("XBOX", 5000, 200, "Microsoft", "One", false);

            List<VideoGame> videoGame = new List<VideoGame>();
            videoGame.Add(videoGame1);
            videoGame.Add(videoGame2);
            videoGame.Add(videoGame3);

            Loja loja = new Loja("Americanas", "118549465165165", livros, videoGame);

            Console.WriteLine("\nLista de Livros: \n");
            loja.ListaLivros();

            Console.WriteLine("");
            livro1.CalculaImposto();
            livro2.CalculaImposto();
            livro3.CalculaImposto();

            Console.WriteLine("\nLista de VideoGames: \n");
            loja.ListaVideoGames();

            Console.WriteLine("");
            videoGame1.CalculaImposto();
            videoGame2.CalculaImposto();
            videoGame3.CalculaImposto();

            Console.WriteLine("");
            loja.CalculaPatrimonio();            
        }
    }
}
