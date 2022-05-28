namespace TransferBank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double carteira, string nome)
        {
            this.TipoConta = tipoconta;
            this.Saldo = saldo;
            this.Credito = carteira;
            this.Nome = nome;
        }

        public bool Sacar (double valorSaque)
        {
            if (this.Saldo - valorSaque < this.Credito *-1 )
            {
                Console.Writeline("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.Writeline("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

            return true;
        }
    }
}