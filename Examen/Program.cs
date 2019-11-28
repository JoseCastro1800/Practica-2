using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int TotalC;
            int P;
            int C;
            //Instanciar la clase operacion
            Solucion Conversion = new Solucion();

            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("Ingrese los entavos");
            TotalC = Convert.ToInt32(Console.ReadLine());
            Conversion.Conversion(TotalC, out P, out C);

            //Imprimir los resultados de la conversion
            Console.WriteLine("El total de pesos: " + P);
            Console.WriteLine("El total de centavos :" + C);
            Console.ReadKey();
            
        }
    }
}
