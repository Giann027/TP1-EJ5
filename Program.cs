using System;

namespace TP1_EJ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas!");
            Console.Title = "Convertir de Pesos a Dolares ";
            double DolarParalelo, DolarOficial, Pesos;
            Console.Write("Ingrese la cantidad de pesos: ");
            Pesos = Convert.ToSingle(Console.ReadLine());
            DolarParalelo = Pesos / 146;
            DolarOficial = Pesos / 93.33;
            Console.WriteLine($"{Pesos} Pesos equivalen a {DolarParalelo} Dolares Paralelos y {DolarOficial} Dolares Oficiales");

        }
    }
}
