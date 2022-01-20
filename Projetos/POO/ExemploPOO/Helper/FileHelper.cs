using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho,"*",SearchOption.AllDirectories);
            var retornoCaminho2 = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);
            var retornoCaminho3 = Directory.GetFiles(caminho,"*2*",SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine("Todas os arquivos das pastas e subpastas " + retorno);
            }
            foreach (var retorno in retornoCaminho2)
            {
                System.Console.WriteLine("Todas os arquivos terminados em.txt " + retorno);
            }
            foreach (var retorno in retornoCaminho3)
            {
                System.Console.WriteLine("Todas os arquivos que contenham 2 independente do que vem antes ou depois " + retorno);
            }
        }

        public void CriarDiretorio (string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio (string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivo (string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        public void CriarArquivoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho)) //using: fecha e libera o arquivo após uso para outros processos usarem
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto (string caminho,string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho)) 
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var retorno = File.ReadAllLines(caminho);

            foreach (var linha in retorno)
            {
                System.Console.WriteLine(linha);
            }

        }

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }

        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobreescrever) //sobreescrever para mover e sobreescrever se já existir um arquivo de mesmo nome naquele
        {
            File.Move(caminho, novoCaminho, sobreescrever);
        }

        public void CopiarArquivo (string caminho, string novoCaminho, bool sobreescrever)
        {
            File.Copy(caminho, novoCaminho, sobreescrever);
        }

        public void DeletarArquivo (string caminho)
        {
            File.Delete(caminho);
        }
    }
}