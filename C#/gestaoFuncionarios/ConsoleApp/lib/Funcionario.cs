
using System.Collections.Generic;

namespace ConsoleApp
{
    class Funcionario
    {
        public string nome;
        public int codigo;
        public List<Cliente> listaDeClientes = new List<Cliente>();

        public Funcionario(string nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public string informacao()
        {
            string clientesInfo = "";
            foreach(Cliente cliente in listaDeClientes)
            {
                clientesInfo = clientesInfo + cliente.infomacao() + "\n";
            }

            return $"O funcionario com o nome {nome} tem o código {codigo} e os seguintes clientes: \n {clientesInfo}";
        }
    }
}
