using System;

// Clase: Bateria
class Bateria
{
    // Propiedades
    public double VoltajeActual { get; set; }
    public double Incremento { get; set; }

    // Método para simular el proceso de carga
    public void SimularCarga()
    {
        int ciclo = 0;

        while (VoltajeActual < 12.6)
        {
            ciclo++;
            VoltajeActual += Incremento;

            if (VoltajeActual > 12.6)
            {
                VoltajeActual = 12.6;
            }

            Console.WriteLine($"Ciclo {ciclo}: Voltaje = {VoltajeActual} V");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Ejercicio 4: Carga de Batería ---");

        // Objeto creado a partir de la clase Bateria
        Bateria miBateria = new Bateria();

        Console.Write("Ingrese el voltaje inicial (V): ");
        miBateria.VoltajeActual = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
        miBateria.Incremento = Convert.ToDouble(Console.ReadLine());

        // Llamada al método
        miBateria.SimularCarga();

        Console.WriteLine("Carga completa alcanzada.");
    }
}