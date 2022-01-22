using Colecoes.helper;

int[] array = new int[5] {43,6,32,89,32};
int[] arrayCopia = new int[10];
OperacoesArray op = new OperacoesArray();

string[] arrayString = op.ConverterParaString (array);

for (int i = 0; i < arrayString.Length; i++)
{
    System.Console.WriteLine(arrayString[i]);    
}


// System.Console.WriteLine("Tamanho atual do array: {0}", array.Length);
// op.Redimensionar(ref array, array.Length * 2);
// System.Console.WriteLine("Novo tamanho do array: {0}", array.Length);

// var valorProcurado = 60;
// var retorno = op.AcharIndex(array,valorProcurado);

// if (retorno > -1)
// {
//     System.Console.WriteLine("Encontrei o valor {0} no índice {1}", valorProcurado, retorno);
// }
// else
// {
//     System.Console.WriteLine("Xiiii, não encontrei o valor {0}", valorProcurado );
// }

// var retorno = op.AcharValor(array,valorProcurado);

// if (retorno > 0)
// {
//     System.Console.WriteLine("Achei o valor {0}", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Hum...Não Achei o valor {0}", valorProcurado);
// }

// var retorno = op.TodosMaiorQue(array,valorProcurado);

// if(retorno)
// {
//     System.Console.WriteLine("Todos os elementos do array são maiores que {0}", valorProcurado);
// }
// else{
//     System.Console.WriteLine("Algum dos elementos do array NÃO são maiores que {0}", valorProcurado);
// }

// var retorno = op.Existe(array, valorProcurado);

// if (retorno)
// {
//     System.Console.WriteLine("Valor {0} encontrado", valorProcurado);
// }
// else
// {
//     System.Console.WriteLine("Valor {0} NÃO encontrado", valorProcurado);
// }

// System.Console.WriteLine("Array Antes da Cópia: ");
// op.ImprimirArray(arrayCopia);

// System.Console.WriteLine("Array Cópia: ");
// op.Copiar(ref array, ref arrayCopia);
// op.ImprimirArray(arrayCopia);

// System.Console.WriteLine("Array Original");
// op.ImprimirArray(array);

// System.Console.WriteLine("Array Ordenado");
// // op.OrdenarBubbleSort(ref array);
// op.Ordenar(array);
// op.ImprimirArray(array);



// int[,] matriz = new int[4,2]
// {
//     {27,7},
//     {09,12},
//     {10,05},
//     {07,10}
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine(matriz[i,j]);
//     }
    
// }



// int[] arrayInteiros = new int[3];

// arrayInteiros[0]=27;
// arrayInteiros[1]=07;
// arrayInteiros[2]=87;

// System.Console.WriteLine("Percorrendo o Array com For");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o Array com ForEach");
// foreach (var item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }