namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno (string nome,string sobrenome, string disciplina) : base (nome, sobrenome) // base para passar os parametros para a classe mãe
        {
            System.Console.WriteLine("Construtor da classe Aluno!");  
        }
    }
}