
namespace ConsoleApp
{
    class Cliente
    {
        public int codigo;
        public string nome;
        public Conta conta;

        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public void inserir(float saldo)
        {
            conta.saldo = conta.saldo + saldo;
        }

        public void tirar(float saldo)
        {
            conta.saldo = conta.saldo - saldo;
        }

        public string infomacao()
        {
            return $"O cliente com o nome {nome} tem o código {codigo} e tem a conta com o numero {conta.numero}.";
        }
    }
}
