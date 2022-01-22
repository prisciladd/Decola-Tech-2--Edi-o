namespace Colecoes.helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort (ref int[] array)     //ref trabalha com o mesmo array e não cria outro
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ",array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar (int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar (ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe (int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue (int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int AcharValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int AcharIndex (int[] array, int index)
        {
            return Array.IndexOf(array,index);
        }

        public void Redimensionar (ref int[] array, int capacidade)
        {
            Array.Resize(ref array,capacidade);
        }

        public string[] ConverterParaString (int[] array)
        {
            return Array.ConvertAll (array, elemento => elemento.ToString());
        }
    }
}