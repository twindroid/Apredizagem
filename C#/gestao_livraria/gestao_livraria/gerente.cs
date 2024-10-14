using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace gestao_livraria
{
    class gerente
    {
        public void master()
        {
            Console.Clear();
            Console.WriteLine("* Entrou com a conta de gerente *");
            Console.WriteLine("*   Selecione a opção desejada  *");
            Console.WriteLine("*********************************");
            Console.WriteLine("* 1 - Criar funcionário");
            Console.WriteLine("* 2 - Eliminar funcionário");          
            Console.WriteLine("* 3 - Consultar Utilizadores");
            Console.WriteLine("* 4 - Consultar livros");
            Console.WriteLine("* 5 - Consultar livro pelo código");            
            Console.WriteLine("* 6 - Vender");
            Console.WriteLine("* 7 - Livros vendidos e receita estimada");
            Console.WriteLine("* 8 - Inicio");
            swcs();
        }
        List<Livro> livros = new List<Livro>();
        Livro adicionar = new Livro();
        string[] funcionario = new string[] { };
        int[] idade = new int[] { };
        int[] salario = new int[] { };
        public void swcs() {
            int opc1 = 0;
            try
            {
                opc1 = Convert.ToInt32(Console.ReadLine());

                switch (opc1)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("* Nome do funcionário: ");
                        funcionario[0] = Console.ReadLine();
                        Console.Write("* Idade: ");
                        idade[0] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("* Salário: ");
                        salario[0] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("* Funcionário inserido");
                        Console.Write("* Nome: ");
                        Console.WriteLine(funcionario[0]);
                        Console.Write("* Idade: ");
                        Console.WriteLine(idade[0]);
                        Console.Write("* Salário: ");
                        Console.WriteLine(salario[0]);
                        Console.WriteLine("Funcionário inserido");
                        break;
                    case 2:
                        Console.Write("Inserir número do funcionário: ");
                        int funcionarioNumero;
                        funcionarioNumero = Convert.ToInt32(Console.ReadLine());
                        if (funcionarioNumero >= 0 && funcionarioNumero < funcionario.Length)
                        {
                            for (int i = funcionarioNumero; i < funcionario.Length - 1; i++)
                            {
                                funcionario[i] = funcionario[i + 1];
                                idade[i] = idade[i + 1];
                                salario[i] = salario[i + 1];
                            }
                            Array.Resize(ref funcionario, funcionario.Length - 1);
                            Array.Resize(ref idade, idade.Length - 1);
                            Array.Resize(ref salario, salario.Length - 1);
                            Console.WriteLine("Funcionário Removido");
                        }
                        else
                        {
                            Console.WriteLine("O funcionário não existe");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < funcionario.Length; i++)
                        {
                            Console.WriteLine(funcionario[i]);
                            Console.WriteLine(idade[i]);
                            Console.WriteLine(salario[i]);
                        }
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
                        // adicionar.Vendido(0);

                        break;
                    case 8:
                        program.Main();
                        break;
                    default:
                        Console.WriteLine("* Opção inválida");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
                master();  
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                master();
                Console.ReadKey();
            }
        }
    }
}
