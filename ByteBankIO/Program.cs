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
            CriarArquivo();
            Console.ReadLine();
        }
        catch (Exception)
        {

            throw;
        }
        
    }
}