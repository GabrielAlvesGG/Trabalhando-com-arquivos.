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

            //var linhas = File.ReadAllLines("contas.txt");
            //Console.WriteLine(linhas.Length);

            //foreach (var linha in linhas)
            //{
            //    Console.WriteLine(linha);
            //}

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length}");

            File.WriteAllText("escrevendoComAClasseFile.txt", "teste WriteAllText");

            Console.WriteLine("Aplicação finalizada");

            Console.ReadLine();
    
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }
}