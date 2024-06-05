using ByteBankIO;
using System;
using System.IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        try
        {
            string enderecoDoArquivo = "C:\\Users\\alves\\Downloads\\CsharpArquivos-main\\CsharpArquivos-main\\contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoDeArquivo);

                //var linha = leitor.ReadLine();

                //var arquivoCompleto = leitor.ReadToEnd();

                //var numero = leitor.Read();

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }

            }

            Console.ReadLine();
        }
        catch (Exception)
        {

            throw;
        }
        
    }


}