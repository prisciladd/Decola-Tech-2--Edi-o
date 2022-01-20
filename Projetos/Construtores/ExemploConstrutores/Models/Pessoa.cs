namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        // public Pessoa() //construtor padrão que não recebe parâmetros
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
            
        // }

        public Pessoa(string nome, string sobrenome)    //construtor que recebe 2 parâmetros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;

            System.Console.WriteLine("Construtor da classe Pessoa!");  
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {nome} {sobrenome}" );
        }
    }
}