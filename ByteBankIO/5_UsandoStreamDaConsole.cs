﻿using System;
using System.IO;

partial class Program
{
    static void UsandoStreamDeEntrada()
    {
        using (var fluxoDeEntrada=Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[10224];

            while (true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, byteslidos);
                fs.Flush();
                Console.WriteLine($"Bytes lidos na console{byteslidos}");
                
            }
        }
    }
}