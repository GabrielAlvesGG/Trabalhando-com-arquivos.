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

                EscritaBinaria();
                LeituraBinaria();

                Console.WriteLine("Aplicação finalizada...");

                Console.ReadLine();
            
    
        }
        catch (Exception ex)
        {

            throw ex;
        }
        
    }
}