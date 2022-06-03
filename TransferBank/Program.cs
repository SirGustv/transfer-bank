using System;

namespace TransferBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta (TipoConta.PessoaFisica, 0, 0, "Gustavo Bernardes Santos");

            Console.WriteLine(minhaConta);
        }
    }
}
