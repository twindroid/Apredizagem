using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_livraria
{
    internal class cliente  
    {
        public void client()
        {
            Console.Clear();
            Console.WriteLine("* Bem-Vindo à biblioteca do IPCA *");
            Console.WriteLine("*   Selecione a opção desejada   *");
            Console.WriteLine("**********************************");
            Console.WriteLine("* 1 - Consultar livros");
            Console.WriteLine("* 2 - Consultar livro pelo código");
            Console.WriteLine("* 3 - Consultar livro pelo género");
            Console.WriteLine("* 4 - Consultar livro pelo autor");
            Console.WriteLine("* 5 - Inicio");
            swcs3();
        }
        List<Livro> livros = new List<Livro>();
        Livro adicionar = new Livro();
        public void swcs3() {
            int opc4 = 0;
            switch (opc4) { 
                case 1:
                    adicionar.ListarLivros(livros);
                    Console.ReadKey();
                    client();
                    break;
                case 2:
                    adicionar.BuscarLivro(livros, "Código do livro: ");

                    Console.ReadKey();
                    client();
                    break;
                case 3:
                    Console.ReadKey();
                    client();
                    break;
                case 4:
                    Console.ReadKey();
                    client();
                    break;
                case 5:
                    program.Main(); 
                    break;
            }
        }
    }
}