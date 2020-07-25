using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica3.Clases;

namespace EjerciciosPractica3.Clases
{
    class cMenu
    {
        public void mostrar()
        {
            string opcion = "";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine("                                     UNIVERSIDAD AUTONOMA DE SANTO DOMINGO      ");
                Console.WriteLine("                                                     UASD      ");
                Console.WriteLine("                                              FACULTAD DE CIENCIAS      ");
                Console.WriteLine("                                             ESCUELA DE INFORMATICA     ");

                Console.WriteLine("                                               PRACTICA NUMERO III      ");
                Console.WriteLine("                     ==========================================================================");
                Console.WriteLine();


                Console.WriteLine("**************** ELIJA UNA OPCION DEL SIGUIENTE MENU *********************");
                Console.WriteLine("1 - Imprimir Gastos De Sueldos Por Turnos (Ejercicio 1).");
                Console.WriteLine("2 - Crear Matriz De 3 Filas Por 4 Columnas (Ejercicio 2).");
                Console.WriteLine("S - Presione la tecla 'S' para salir");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.Write("Seleccione Una Opcion: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cUtilidades.GastosxTurnos();
                        break;

                    case "2":
                        cUtilidades.Matriz3x4();
                        break;

                    default:
                        Console.WriteLine("<<<<<<<<<<< Hasta pronto!!! >>>>>>>>>>");
                        opcion = "s";
                        break;
                }

            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();

        }
    }
}
