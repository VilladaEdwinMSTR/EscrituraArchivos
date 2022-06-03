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
        //Clase Persona
        public class Persona
        {
            //Campos de la clase
            public string nombre;
            public byte edad;

            //Metodo constructor
            public Persona(string nombre, byte edad)
            {
                //Diferenciar campos de parametros
                this.nombre = nombre;
                this.edad = edad;
            }
        }
        static void Main(string[] args)
        {
            //Variable booleana para salir de ciclo
            bool x = false;

            //Ciclo para repetir el mensaje
            do
            {
                //Limpieza de pantalla
                Console.Clear();
                try
                {
                    //Despliegue de mensaje
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\tCAPTURA DE DATOS\n");
                    Console.ResetColor();

                    //Captura de datos
                    Console.Write("Ingrese su nombre:");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese su edad: ");
                    byte edad = byte.Parse(Console.ReadLine());

                    //Variable en true para salir de ciclo
                    x = true;

                        //Creacion de objeto
                        Persona persona = new Persona(nombre, edad);

                        StreamWriter sw = new StreamWriter("ejemplo.txt", true);
                        //Si el archivo no existe, lo creara
                        //SI el archivo existe, escribira en el

                    //Escritura de texto en archivo
                        sw.WriteLine(persona.nombre + " " + persona.edad);

                        //Cerrar el archivo
                        sw.Close();

                    //Despliegue de mensaje
                        Console.WriteLine("Escribiendo . . . . ");
                        Console.ReadKey();                   
                }
                //Excepcion de formato
                catch (FormatException)
                {
                    //Impresion de mensaje de color rojo
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ingreso el formato correcto");
                    Console.ResetColor();
                }
                //Mensaje para continuar
                Console.Write("Presione ENTER para continuar . . . ");
                Console.ReadKey();
            } while (x==false); //fin de ciclo
        }
        //string[] lines = {"Esto es la primer linea",
        //"Esto es la segunda linea",
        //"Esto es la tercer linea"};

        //Ciclo para almacenar en arreglo
        //for (int i = 0; i < lines.Length; i++)
        //{
        //    Console.Write("Ingrese su nombre: ");
        //    lines[i] = Console.ReadLine();
        //}
        //Recorrer el arreglo para escribir las lineas en el archivo
        //foreach (string line in lines)
        //{
        //    //Escribir en el archivo
        //    sw.WriteLine(line);
        //}
    }
}
