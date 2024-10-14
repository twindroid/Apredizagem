using ConsoleApp.log;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static List<Cliente> listaClientes = new List<Cliente>();
        static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Clientes");
                Console.WriteLine("2 - Funcionários");
                Console.WriteLine("0 - Sair");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0: break;
                    case 1:
                        subMenuClientes();
                        break;
                    case 2: 
                        subMenuFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Opçao Inválida");
                        break;
                }
            } while (option != 0);            
        }

        private static void subMenuClientes()
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Procurar Cliente");
                Console.WriteLine("0 - Back");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 0: break;
                    case 1:
                        inserirCliente();
                        pressionarEnterParaContinuar();
                        break;
                    case 2:
                        listarClientes();
                        pressionarEnterParaContinuar();
                        break;
                    case 3:
                        apagarCliente();
                        pressionarEnterParaContinuar();
                        break;
                    case 4:
                        procurarCliente();
                        pressionarEnterParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opçao Invalida");
                        break;
                }

            } while (option != 0);
        }

        private static void subMenuFuncionarios()
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Inserir Funcionario");
                Console.WriteLine("2 - Atribuir cliente a funcionario");
                Console.WriteLine("3 - Lista funcionarios");
                Console.WriteLine("0 - Back");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 0: break;
                    case 1:
                        inserirFuncionario();
                        pressionarEnterParaContinuar();
                        break;
                    case 2:
                        atribuirClienteAFuncionario();
                        pressionarEnterParaContinuar();
                        break;
                    case 3:
                        listarFuncionarios();
                        pressionarEnterParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opçao Invalida");
                        break;
                }
            } while (option != 0);
        }

        private static void listarFuncionarios()
        {
            foreach(Funcionario func in listaFuncionarios)
            {
                Console.WriteLine(func.informacao());
            }
        }

        private static void atribuirClienteAFuncionario()
        {
            Console.Write("Insira código cliente: ");
            var codigoCliente = int.Parse(Console.ReadLine());
            var indexCliente = listaClientes.FindIndex(cliente => cliente.codigo == codigoCliente);
            if(indexCliente != -1)
            {
                Cliente cliente = listaClientes[indexCliente];
                Console.Write("Insira código funcionario: ");
                var codigoFuncionario = int.Parse(Console.ReadLine());
                var indexFunc = listaFuncionarios.FindIndex(func => func.codigo == codigoFuncionario);
                if(indexFunc != -1)
                {
                    Funcionario func = listaFuncionarios[indexFunc];
                    func.listaDeClientes.Add(cliente);
                } else
                {
                    Console.WriteLine("Funcionario nao existe!!");
                }
            } else
            {
                Console.WriteLine("Cliente nao existe!!");
            }
        }

        private static void inserirFuncionario()
        {
            Console.Write("Insira código: ");
            var codigo = int.Parse(Console.ReadLine());
            Console.Write("Insira nome: ");
            var nome = Console.ReadLine();
            Funcionario funcionario = new Funcionario(nome, codigo);
            listaFuncionarios.Add(funcionario);
            Console.WriteLine("Funcionario inserido com successo!!!");
        }

        private static void procurarCliente()
        {
            Console.Write("Escreva o codigo do cliente:");
            var codigoCliente = int.Parse(Console.ReadLine());
            var index = listaClientes.FindIndex(cliente => cliente.codigo == codigoCliente);
            if(index != -1)
            {
                var clienteEncontrado = listaClientes[index];
                Console.WriteLine(clienteEncontrado.infomacao());
            } else
            {
                Console.WriteLine("Cliente não encontrado!!!");
            }
        }

        private static void apagarCliente()
        {
            /*Console.Write("Escreva o codigo do cliente:");
            var codigoCliente = int.Parse(Console.ReadLine());
            int indexCodigoCliente = -1;
            for (int i = 0; i < listaClientes.Count; i++)
            {
                Cliente cliente = listaClientes[i];
                if (codigoCliente == cliente.codigo)
                {
                    indexCodigoCliente = i;
                    break;
                }
            }

            if(indexCodigoCliente != -1)
            {
                listaClientes.RemoveAt(indexCodigoCliente);
            }*/

            Console.Write("Escreva o codigo do cliente:");
            var codigoCliente = int.Parse(Console.ReadLine());
            var index = listaClientes.FindIndex(cliente => cliente.codigo == codigoCliente);
            if(index != -1)
            {
                Console.Clear();
                listaClientes.RemoveAt(index);
                Console.WriteLine("Cliente apagado com successo!!");
            } else
            {
                Console.WriteLine($"Não existe o cliente com o código {codigoCliente}.");
            }
        }

        private static void listarClientes()
        {
            if(listaClientes.Count == 0)
            {
                Console.WriteLine("Não existem clientes!!!");
                return;
            }

            foreach(Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.infomacao());
            }

            /*for(int i = 0; i < listaClientes.Count; i++)
            {
                Cliente cliente = listaClientes[i];
                Console.WriteLine(cliente.infomacao());
            }*/
        }

        private static void inserirCliente()
        {
            Console.Write("Insira código: ");
            var codigo = int.Parse(Console.ReadLine());
            Console.Write("Insira nome: ");
            var nome = Console.ReadLine();
            Cliente cliente = new Cliente(codigo, nome);
            var conta = new Conta();
            conta.numero = new Random().Next(1000);
            cliente.conta = conta;
            listaClientes.Add(cliente);
            Console.WriteLine("Cliente inserido com successo");
        }

        private static void pressionarEnterParaContinuar()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();
        }
    }
}