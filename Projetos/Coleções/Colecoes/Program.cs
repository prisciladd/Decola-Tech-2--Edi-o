using System.Collections.Generic;
using Colecoes.helper;

int[] numeros = new int[10] {3,67,23,66,9,12,32,66,9,3};

var minimo = numeros.Min();
var maximo = numeros.Max();
var medio = numeros.Average();
var soma = numeros.Sum();
var unicos = numeros.Distinct().ToArray();

System.Console.WriteLine("Valor mínimo {0}", minimo);
System.Console.WriteLine("Valor máximo {0}", maximo);
System.Console.WriteLine("Valor médio {0}", medio);
System.Console.WriteLine("Valor da soma {0}", soma);
System.Console.WriteLine("Números únicos sem repetição {0}", unicos);

var numerosParQuery =
        from num in numeros
        where num % 2 == 0
        orderby num
        select num;

var numerosParMetodo = numeros.Where(x => x % 2 == 0).OrderBy (x => x).ToList();

System.Console.WriteLine("Numeros pares Query: " + string.Join(", ", numerosParQuery));
System.Console.WriteLine("Numeros pares Método: " + string.Join(", ", numerosParMetodo));

// Dictionary<string,string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("RJ", "Rio de Janeiro");

// // System.Console.WriteLine("Valor original:");
// // System.Console.WriteLine(estados[valorProcurado]);

// // System.Console.WriteLine("Valor atualizado:");
// // estados[valorProcurado] = "RJ - teste de atualização";
// // System.Console.WriteLine(estados[valorProcurado]);

// foreach (KeyValuePair<string,string> item in estados)
// {
//     // System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
// }

// string valorProcurado = "SC";

// //var teste= estados["SC"];

// if(estados.TryGetValue(valorProcurado, out string estadoEncontrado)) // acessando dicionário de forma segura
// {
//     System.Console.WriteLine(estadoEncontrado);
// }
// else
// {
//     System.Console.WriteLine("A chave {0} não foi encontrada", valorProcurado);
// }


// System.Console.WriteLine($"Removendo o valor {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
// }

// Stack<string> livros = new Stack<string>();

// livros.Push ("Assassins Creed");
// livros.Push ("Quarto de Despejo");
// livros.Push ("Inteligência Positiva");

// System.Console.WriteLine($"Promessa para 2022 ler esta pilha de livros: {livros.Count}");

// System.Console.WriteLine("Segunda eu vou começar com {0}", livros.Peek());

// while(livros.Count > 0)
// {
//     System.Console.WriteLine("Ufa! menos um... {0}", livros.Pop());

// }

// System.Console.WriteLine("Acho que terminei {0}", livros.Count);

// Queue<string> filaBanco= new Queue<string>();

// filaBanco.Enqueue("Leandro");
// filaBanco.Enqueue("Sueli");
// filaBanco.Enqueue("Rozalia");

// System.Console.WriteLine("Pessoas na fila: {0} ", filaBanco.Count);
// System.Console.WriteLine(" - Que droga o banco ainda não abriu...");
// System.Console.WriteLine(" - Agora sim! Vai lá {0}", filaBanco.Peek());

// while (filaBanco.Count > 0 )
// {
//     System.Console.WriteLine("Próximo... {0}", filaBanco.Dequeue());
// }

// System.Console.WriteLine("Pessoas na fila: {0}", filaBanco.Count);

// List<String> estados = new List<string> {"SP","MG","BA"};
// String[] estadosArray = new String[2] {"SC","MT"};

// // estados.Add("SP");
// // estados.Add("RJ");
// // estados.Add("BA");

// System.Console.WriteLine("Total de items na lista: {0}", estados.Count);    //count é semelhante ao Array.Lenght

// System.Console.WriteLine("Listando todos os itens");
// OperacoesLista lista = new OperacoesLista();

// lista.ImprimirLista(estados);

// // System.Console.WriteLine("Adicionando itens...");
// // estados.AddRange(estadosArray);

// System.Console.WriteLine("Adicionando itens por índice");
// estados.Insert(1,"RJ");

// // System.Console.WriteLine("Removendo item...");
// // estados.Remove("RJ");

// lista.ImprimirLista(estados);

// foreach (var item in estados)
// {
//     System.Console.WriteLine(item);
// }

// int[] array = new int[5] {43,6,32,89,32};
// int[] arrayCopia = new int[10];
// OperacoesArray op = new OperacoesArray();

// string[] arrayString = op.ConverterParaString (array);

// for (int i = 0; i < arrayString.Length; i++)
// {
//     System.Console.WriteLine(arrayString[i]);
// }


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