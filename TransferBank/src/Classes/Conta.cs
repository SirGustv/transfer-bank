namespace TransferBank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Carteira { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double carteira, string nome)
        {
            this.TipoConta = tipoconta;
            this.Saldo = saldo;
            this.Carteira = carteira;
            this.Nome = nome;
        }
    }
}