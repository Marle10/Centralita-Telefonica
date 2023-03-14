using System;
using System.Collections.Generic;
using Central_Telefonica;

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

        Console.ReadKey();
    }
}