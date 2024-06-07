using System;
using System.IO;

partial class Program
{
    static void EscritaBinaria()
    {
        try
        {

            var caminhoNovoArquivo = "contaCorrente.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new BinaryWriter(fluxoDeArquivo))
            {
                escritor.Write(456);    //número da Agência
                escritor.Write(546544); //número da conta
                escritor.Write(4000.50); //Saldo
                escritor.Write("Gustavo Braga"); //Titular

            }

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    static void LeituraBinaria()
    {
        try
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitura = new BinaryReader(fs))
            {
                var agencia = leitura.ReadInt32();
                var numeroConta = leitura.ReadInt32();
                var saldo = leitura.ReadDouble();
                var titular = leitura.ReadString();

                Console.WriteLine($"{agencia}, {numeroConta}, {saldo}, {titular}");

            }

        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}