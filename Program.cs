using System;
using System.Collections.Generic;
using Centralita_Telefonica;

class Practica2
{
    static void Main(string[] args)
    {
        Centralita centralita = new Centralita();

        LlamadaLocal llamadaLocal = new LlamadaLocal("111111111", "222222222", 60);
        centralita.registrarLlamada(llamadaLocal);

        LlamadaProvincial llamadaProvincial1 = new LlamadaProvincial("111111111", "333333333", 120, 1);
        centralita.registrarLlamada(llamadaProvincial1);

        LlamadaProvincial llamadaProvincial2 = new LlamadaProvincial("222222222", "444444444", 180, 2);
        centralita.registrarLlamada(llamadaProvincial2);

        centralita.informe();

        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hola, la llamada fue realizada en {currentDate:d} a las {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Presione cualquier letra para salir...");


        Console.ReadKey(true);
    }
}

