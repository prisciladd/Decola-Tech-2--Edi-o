using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.Collections.Generic;

FileHelper helper = new FileHelper();

var local = "c://TrabalhandoComArquivos";
var localComPathCombine = Path.Combine(local,"pasta teste 1"); //path combine: facilita escrita de caminhos sem precisar escrever c://TrabalhandoComArquivos/pasta teste 3/subpasta teste 3
var caminhoArquivo = Path.Combine(local, "arquivo-teste-1.txt");
var caminhoArquivoCopia = Path.Combine(local, "arquivo-teste-1-bkp.txt");
var caminhoArquivoStream = Path.Combine(local, "arquivo-teste-stream-1.txt");
var novoCaminho = Path.Combine(local, "pasta teste 2");

List<string> listaString = new List<string> ();
listaString.Add("Linha 1");
listaString.Add("Linha 2");
listaString.Add("Linha 3");

List<string> listaString2 = new List<string> ();
listaString.Add("Linha 4");
listaString.Add("Linha 5");
listaString.Add("Linha 6");

// System.Console.WriteLine("Criando diretório... " + localComPathCombine);
// helper.CriarDiretorio(localComPathCombine);
// helper.ListarArquivosDiretorios(local);
// helper.ListarDiretorios(local);
// helper.ApagarDiretorio(localComPathCombine, true);
// helper.CriarArquivo(caminhoArquivo,"Testando 1,2,3...");
// helper.CriarArquivoStream(caminhoArquivoStream,listaString);
// helper.AdicionarTextoStream(caminhoArquivoStream,listaString2);
// helper.LerArquivo(caminhoArquivo);
// helper.LerArquivoStream(caminhoArquivoStream);
// helper.MoverArquivo(caminhoArquivoStream, novoCaminho,false);
// helper.CopiarArquivo(caminhoArquivo,caminhoArquivoCopia,false);
helper.DeletarArquivo(caminhoArquivoCopia);



// ICalculadora calc = new Calculadora();
// System.Console.WriteLine(calc.Multiplicar(10,5));
// System.Console.WriteLine(calc.Somar(5,5));

// Computador comp = new Computador();
// System.Console.WriteLine(comp.ToString());

// Corrente c1 = new Corrente();
// c1.Creditar(1000);
// c1.Creditar(1000);
// c1.Creditar(100);
// c1.ObterSaldo();
// Calculadora calc = new Calculadora();

// System.Console.WriteLine("Resultado da primeira soma:" + calc.somar(10,10));
// System.Console.WriteLine("Resultado da segunda soma:" + calc.somar(10,10,10));

// Pessoa p0 = new Pessoa();

// p0.Nome = "Bob";
// p0.Idade = 20;
// p0.documento = 256347890;

// p0.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Bob";
// p1.Idade = 45;
// p1.documento = 433587320;
// p1.salario = 2000;

// p1.Apresentar();

// Aluno p2 = new Aluno();

// p2.Nome = "Leon";
// p2.Idade = 20;
// p2.documento = 433587320;
// p2.nota = 10;

// p2.Apresentar();

// //valores válidos
// Retangulo r = new Retangulo();
// r.DefinirMedidas(30,30);
// System.Console.WriteLine($"Área: {r.ObterArea()}");

// //valores válidos
// Retangulo r2 = new Retangulo();
// r2.DefinirMedidas(0,0);
// System.Console.WriteLine($"Área: {r2.ObterArea()}");

 