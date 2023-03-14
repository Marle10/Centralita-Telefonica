using System;
namespace Central_Telefonica
{
    class LlamadaProvincial : Llamada
    {
        private int franja;

        public LlamadaProvincial(string numOrigen, string numDestino, int duracion, int franja)
        {
            this.numOrigen = numOrigen;
            this.numDestino = numDestino;
            this.duracion = duracion;
            this.franja = franja;

            switch (franja)
            {
                case 1:
                    this.costo = duracion * 0.20;
                    break;
                case 2:
                    this.costo = duracion * 0.25;
                    break;
                case 3:
                    this.costo = duracion * 0.30;
                    break;
            }
        }

        public override string ToString()
        {
            return "Llamada provincial de " + this.numOrigen + " a " + this.numDestino + " de " + this.duracion + " segundos en franja " + this.franja + ". Costo: " + this.costo + " euros.";
        }
    }
}