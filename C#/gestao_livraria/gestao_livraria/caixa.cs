using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao_livraria
{
    internal class caixa
    {
        public void cx()
        {
            Console.Clear();
            Console.WriteLine("* Entrou com a conta de caixa *");
            Console.WriteLine("* Selecione a opção desejada  *");
            Console.WriteLine("*******************************");
            Console.WriteLine("* 1 - Consultar livros");
            Console.WriteLine("* 2 - Consultar stock");
            Console.WriteLine("* 3 - Livros vendidos e receita estimada");
            Console.WriteLine("* 4 - Vender");
            Console.WriteLine("* 5 - Inicio");
            swcs2();
        }
        List<Livro> livros = new List<Livro>();
        Livro adicionar = new Livro();
        public void swcs2() {
            int opc3 = 0;
            opc3 = Convert.ToInt32(Console.ReadLine());
            switch (opc3){
                case 1:
                    adicionar.ListarLivros(livros);
                    break;
                case 2:
                    
                    break;
                case 3:
                    // adicionar.Vendido(0);

                    break;
                case 4:
                    // adicionar.Vendido(0);

                    break;
                case 5: 
                    program.Main();
                    break;
            }
            Console.ReadKey();
            cx();
        }

    }
}
