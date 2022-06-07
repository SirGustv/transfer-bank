using System;

namespace TransferBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //ListarContas();
                        break;
                
                    case "2":
                        //NovaConta();
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
