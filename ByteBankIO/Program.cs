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

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {

                var buffer = new byte[1024];

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);

                    Console.WriteLine($" Bytes lidos: {numeroDeBytesLidos}");

                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
                fluxoDoArquivo.Close();
                Console.ReadLine();
            }

        }
        catch (Exception e)
        {
            throw e;
        }
       
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);



        Console.Write(texto);
    }
}