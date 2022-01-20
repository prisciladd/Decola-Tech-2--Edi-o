namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected int saldo;

        public abstract void Creditar(int valor);

        public void ObterSaldo()
        {
            System.Console.WriteLine("Seu saldo é :" + saldo);
        }
    }
}