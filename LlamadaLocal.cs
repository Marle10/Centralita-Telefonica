using System;
namespace Central_Telefonica
{ 
}

class LlamadaLocal : Llamada
{
    public LlamadaLocal(string numOrigen, string numDestino, int duracion)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
        this.costo = duracion * 0.15;
    }

    public override string ToString()
    {
        return "Llamada local de " + this.numOrigen + " a " + this.numDestino + " de " + this.duracion + " segundos. Costo: " + this.costo + " euros.";
    }
}