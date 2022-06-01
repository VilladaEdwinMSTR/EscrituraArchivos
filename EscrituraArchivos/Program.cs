using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt");
            //Si el archivo no existe, lo creara
            //SI el archivo existe, escribira en el

            string[] lines = {"Esto es la primer linea",
            "Esto es la segunda linea",
            "Esto es la tercer linea"};

            //Ciclo para almacenar en arreglo
            for(int i = 0; i < lines.Length; i++)
            {
                Console.Write("Ingrese su nombre: ");
                lines[i] = Console.ReadLine();
            }

            //Recorrer el arreglo para escribir las lineas en el archivo
            foreach(string line in lines) 
            {
                //Escribir en el archivo
                sw.WriteLine(line);               
            }

            //Cerrar el archivo
            sw.Close();

            Console.WriteLine("Escribiendo . . . . ");
            Console.ReadKey();
        }
    }
}
