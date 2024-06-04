using ByteBankIO;
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string enderecoDoArquivo = "C:\\Users\\alves\\Downloads\\CsharpArquivos-main\\CsharpArquivos-main\\contas.txt";
            var numeroDeBytesLidos = -1;

            
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            var buffer = new byte[1024];

            

            while (numeroDeBytesLidos!= 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
           
            Console.ReadLine();
        }
        catch (Exception e)
        {
            throw e;
        }
       
    }

    static void EscreverBuffer(byte[] buffer)
    {

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        //foreach (var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}