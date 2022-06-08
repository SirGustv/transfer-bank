using System;
using System.Collections.Generic;

namespace TransferBank
{
    class Program
    {
        static List<Conta> listConta = new List<Conta>();
        static void Main(string[] args)
        {
            Console.Clear();
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;

                    case "2":
                        NovaConta();
                        break;

                    case "3":
                        //Transferir();
                        break;

                    case "4":
                        //Sacar();
                        break;

                    case "5":
                        //Depositar();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(opcaoUsuario);
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadKey();
        }

        private static void ListarContas()
        {
            if (listConta.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for (int i = 0; i < listConta.Count; i++)
            {
                Conta conta = listConta[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }


        }

        private static void NovaConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Física ou 2 para Conta Juridica");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                         nome: entradaNome,
                                         saldo: entradaSaldo,
                                         carteira: entradaCredito);

            listConta.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine($"\nBank Service ao seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:\n");

            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair\n");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
