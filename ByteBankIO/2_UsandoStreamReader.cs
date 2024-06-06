using ByteBankIO;
using System;
using System.IO;

partial class Program
{
    static void UsandoStreamReader()
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
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"{contaCorrente.Titular.Nome} : Conta Numero {contaCorrente.Numero}, ag {contaCorrente.Agencia}, saldo {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                }

            }

            Console.ReadLine();
        }
        catch (Exception)
        {

            throw;
        }

    }

    public static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        try
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
            resultado.Depositar(saldoComDouble);
            resultado.Titular = titular;

            return resultado;
        }
        catch (Exception e)
        {

            throw e;
        }
    }
}