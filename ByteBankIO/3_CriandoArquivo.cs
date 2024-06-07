using System;
using System.IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        try
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456, 7895, 4785.40, Gustavao Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
            Console.ReadLine();
        }
        catch (Exception)
        {

            throw;
        }

    }

    static void CriarArquivoComWriter()
    {
        try
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    static void TestaEscrita()
    {
        try
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // Despeja o buffer para o Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Clique enter");
                    Console.ReadLine();
                }
                
             
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}