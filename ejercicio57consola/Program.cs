using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrePersona, mayorPersona = null, menorPersona = null;
            int edadPersona, cantidadPersonas, mayorEdad = 0, menorEdad = 150;
            double promedioEdades = 0;
            int personasEntre25y40 = 0;

            Console.WriteLine("Calcule el mayor, menor y el promedio de edades");
            Console.Write("Ingrese la cantidad de personas a calcular:  ");
            cantidadPersonas = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador < cantidadPersonas+1; contador++)
            {
                Console.Write($"Ingrese el nombre de la {contador}° persona: ");
                nombrePersona = Console.ReadLine();
                Console.Write($"Ingrese la edad de {nombrePersona}:  ");
                edadPersona = Convert.ToInt32(Console.ReadLine());

                if (edadPersona>mayorEdad)
                {
                    mayorPersona = nombrePersona;
                    mayorEdad = edadPersona;
                }
                
                if (edadPersona<menorEdad)
                {
                    menorPersona = nombrePersona;
                    menorEdad = edadPersona;
                }
               
                if (edadPersona>25 && edadPersona<40)
                {
                    personasEntre25y40 = personasEntre25y40 + 1;
                }
                promedioEdades = promedioEdades + edadPersona;
            }
            Console.Clear();
            promedioEdades = promedioEdades / cantidadPersonas;
            Console.WriteLine($"La persona de menor edad es {menorPersona} con {menorEdad}");
            Console.WriteLine($"La persona de mayor edad es {mayorPersona} con {mayorEdad}");
            Console.WriteLine($"El promedio de edades es de {promedioEdades}");
            Console.WriteLine($"La cantidad de personas entre 25 y 40 años es {personasEntre25y40}");
            Console.ReadLine();
        }


    }
}
