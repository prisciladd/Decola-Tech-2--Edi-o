namespace Colecoes.helper
{
    public class OperacoesLista
    {
        public void ImprimirLista (List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
        {
            System.Console.WriteLine("Este é o item {0} na posição {1}", lista[i], i);    
        }
        }
        
    }
}