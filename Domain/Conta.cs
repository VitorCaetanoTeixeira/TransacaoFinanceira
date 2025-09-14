namespace TransacaoFinanceira.Domain
{
    public class Conta{
        public long numero {get;}
        public decimal saldo {get; private set;}

        public Conta(long numero, decimal saldo){
            this.numero = numero;
            this.saldo = saldo;
        }

        public bool Debitar(decimal valor){
            if (this.saldo < valor) return false;
            this.saldo -= valor;
            return true;
        }

        public void Creditar(decimal valor)
        {
            this.saldo += valor; 
        }
    }
}