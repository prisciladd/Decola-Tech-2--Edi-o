namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(int valor)    
        {
            base.saldo = saldo + valor; //base é semelhante ao this porém é melhor pois indica que estamos alterando a propriedade da classe base/mãe
        }
    }
}