using ByteBankIO;
using System;
using System.IO;
using System.Text;

partial class Program
{
    static void LendoTodasAsLinhas()
    {
        try
        {

            var linhas = File.ReadAllLines("contas.txt");
            

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine(linhas.Length);


        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    static void LendoTotalBytes()
    {
        try
        {
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length}");
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    
    static void EscrevendoUmArquivo()
    {
        try
        {
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