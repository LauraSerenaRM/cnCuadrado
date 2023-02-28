using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnCuadrado
{/// <summary>
/// Nombre: Laura Serena Rivera Mejía
/// Fecha: 24-02-2023
/// Descripción: Este programa solicita el valor de un lado de un cuadrado y calcula su perimetro y área.
/// </summary>
    internal class ClsCuadrado
    {   //Declaración de variables
        int Lado;
        static void Main(string[] args)
        {

            //Se crea un objeto de la Clase Cuadrado
            ClsCuadrado oCuadrado = new ClsCuadrado();
            //Se llaman los métodos a partir del objeto cuadrado
            oCuadrado.Solicitarvalorlado();
            oCuadrado.CalcularPerimetro();
            oCuadrado.CalcularArea();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();
        }

        //Método 1
        public void Solicitarvalorlado()
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado");
            Lado = int.Parse(Console.ReadLine());

        }
        //Método 2
        public void CalcularPerimetro()
        {
            int Perimetro;
            Perimetro = Lado * 4;
            Console.WriteLine("El perimetro del cuadrado es " + Perimetro);

        }
        //Nétodo 3
        public void CalcularArea()
        {
            int Area;
            Area = Lado * Lado;
            Console.WriteLine("El área del cuadrado es " + Area);
        }



    }

}
