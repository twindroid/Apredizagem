using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace gestao_livraria
{
    class program
    {
        public static void Main()
        {
                string user;
                string password;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("* Bem-vindo à biblioteca do IPCA *");
            Console.WriteLine("*   Faça login para continuar    *");
            Console.WriteLine("**********************************");
            Console.Write("* Utilizador: ");
            user = Console.ReadLine();
            Console.Write("* Password: ");
            password = Console.ReadLine();
            if (user == "gerente" && password == "gerente")
            {
                gerente g = new gerente();
                g.master();
            }
            else if (user == "repositor" && password == "repositor")
            {
                repositor r = new repositor();
                r.rep();
            }
            else if (user == "caixa" && password == "caixa")
            {
                caixa c = new caixa();
                c.cx();
            }
            else if (user == "cliente" && password == "cliente")
            {
                cliente cl = new cliente();
                cl.client();
            }
            else
            {
                Console.WriteLine("Utilizador ou password inválidos");
                Console.ReadKey();
                inicio();
            }
        }
        static void inicio()
        {
            Main();
        }
    }
    class Livro
    {
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public double Preco { get; set; }
        public double TaxaIVA { get; set; }
        public int Stock { get; set; }
        public int Vendidos { get; set; }
        static List<Livro> livros = new List<Livro>();
        public void AdicionarLivro(List<Livro> livros)
        {
            Console.Write("Código do livro: ");
            string codigo = Console.ReadLine();
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn =Console.ReadLine();
            Console.Write("Género: ");
            string genero = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("IVA a aplicar: ");
            double taxaIVA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Livro livro = new Livro
            {
                Titulo = titulo,
                Codigo = codigo,
                Autor = autor,
                ISBN = isbn,
                Genero = genero,
                Preco = preco,
                TaxaIVA = taxaIVA,
                Stock = stock,
                Vendidos = 0
            };
            livros.Add(livro);
            Console.WriteLine("Livro inserido");
            Console.ReadKey();
        }
        public void ListarLivros(List<Livro> livros)
        {
            Console.WriteLine("Livros:");
            foreach (Livro livro in livros)
            {
                Console.WriteLine("Livro " + livro.Codigo);
                Console.WriteLine("Título: " + livro.Titulo);
                Console.WriteLine("Autor: " + livro.Autor);
                Console.WriteLine("ISBN: " + livro.ISBN);
                Console.WriteLine("Gênero: " + livro.Genero);
                Console.WriteLine("Preço: " + livro.Preco);
                Console.WriteLine("Taxa IVA: " + livro.TaxaIVA);
                Console.WriteLine("Quantidade: " + livro.Stock);
                Console.WriteLine();
            }
        }
        public void EliminarLivro(List<Livro> livros)
        {
            Console.Write("Insira o código do livro a eliminar: ");
            string codigo = Console.ReadLine();
            livros.RemoveAll(livro => livro.Codigo == codigo);
            Console.WriteLine("Livro eliminado");
        }
        public void AtualizarLivro(List<Livro> livros)
        {
            Console.Write("Código do livro a ser atualizado: ");
            string codigo = Console.ReadLine();
            Livro livroEncontrado = livros.Find(x => x.Codigo == codigo);
            if (livroEncontrado != null)
            {
                Console.Write("Novo título: ");
                livroEncontrado.Titulo = Console.ReadLine();
                Console.Write("Novo autor: ");
                livroEncontrado.Autor = Console.ReadLine();
                Console.Write("Novo ISBN: ");
                livroEncontrado.ISBN = Console.ReadLine();
                Console.Write("Novo gênero: ");
                livroEncontrado.Genero = Console.ReadLine();
                Console.Write("Novo preço: ");
                livroEncontrado.Preco = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nova taxa IVA: ");
                livroEncontrado.TaxaIVA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nova quantidade: ");
                livroEncontrado.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Livro atualizado");
            }
            else
            {
                Console.WriteLine("Livro não encontrado");
            }
        }
        public Livro BuscarLivro(List<Livro> livros, string codigo)
        {
            foreach (Livro livro in livros)
            {
                if (livro.Codigo == codigo)
                {
                    return livro;
                }
            }
            return null;
        }
        public void VenderLivro(string codigo, int quantidade)
        {
            Livro livro = livros.Find(x => x.Codigo == codigo);
            if (livro != null)
            {
                if (livro.Stock >= quantidade)
                {
                    livro.Stock -= quantidade;
                    livro.Vendidos += quantidade;
                    Console.WriteLine("Venda realizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Não há livros suficientes em stock");
                }
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        //public void Vendido(int codigo)
      //  {
       //     Livro livro = livros.Find(x => x.Codigo == codigo);
       ///     {
       //         int vendidos = livro.Vendidos;
        //        Console.WriteLine("Número de livros vendidos: " + vendidos);
         //   }
       //     else
         //   {
         //       Console.WriteLine("Livro não encontrado.");
       //     }
    //    }
    }
}