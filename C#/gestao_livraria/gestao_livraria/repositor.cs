using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_livraria
{
    internal class repositor
    {
        public void rep()
        {
            Console.Clear();
            Console.WriteLine("* Entrou com a conta de repositor *");
            Console.WriteLine("*    Selecione a opção desejada   *");
            Console.WriteLine("***********************************");
            Console.WriteLine("* 1 - Adicionar livro");
            Console.WriteLine("* 2 - Eliminar livro");
            Console.WriteLine("* 3 - Atualizar livro");
            Console.WriteLine("* 4 - Consultar livros");
            Console.WriteLine("* 5 - Consultar livro pelo código");
            Console.WriteLine("* 6 - Livros vendidos");
            Console.WriteLine("* 7 - Inicio");
            swcs1();
        }
        List<Livro> livros = new List<Livro>();
        Livro adicionar = new Livro();
        void swcs1() {
            int opc2 = 0;
            int ou1ou2 = 0;
            opc2 = Convert.ToInt32(Console.ReadLine());
            switch (opc2)
            {
                case 1:
                    Console.WriteLine("* 1 - Criar");
                    Console.WriteLine("* 2 - Adicionar stock");
                    ou1ou2 = Convert.ToInt32(Console.ReadLine());
                    if (ou1ou2 == 1)
                    {
                        adicionar.AdicionarLivro(livros);
                    }
                    else if (ou1ou2 == 2)
                    {
                        Console.Write("Número do livro: ");
                        adicionar.VenderLivro("", 0);
                    }
                    break;
                case 2:
                    adicionar.EliminarLivro(livros);
                    break;
                case 3:
                    adicionar.AtualizarLivro(livros);
                    break;
                case 4:
                    adicionar.ListarLivros(livros);
                    break;
                case 5:
                    adicionar.BuscarLivro(livros, "Código do livro: ");
                    break;
                case 6:
                   // adicionar.Vendido(0);
                    break;
                case 7:
                    program.Main();
                    break;
            }
            Console.ReadKey();
            rep();
        }
    }
}
