using System;
namespace Centralita_Telefonica
{
    class Centralita
    {
        private int numLlamadas = 0;
        private double facturacionTotal = 0.0;

        public void registrarLlamada(Llamada llamada)
        {
            Console.WriteLine(llamada.ToString());
            this.numLlamadas++;
            this.facturacionTotal += llamada.costo;
        }

        public void informe()
        {
            Console.WriteLine("Número total de llamadas: " + this.numLlamadas);
            Console.WriteLine("Facturación total: " + this.facturacionTotal + " euros.");
        }
    }
}