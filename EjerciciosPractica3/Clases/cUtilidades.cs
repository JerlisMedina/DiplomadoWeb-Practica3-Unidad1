using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjerciciosPractica3.Clases;

namespace EjerciciosPractica3.Clases
{
    class cUtilidades
    {
        public static void GastosxTurnos()
        {
            double[] turnoManana = new double[4];
            double[] turnoTarde = new double[4];
            double gastoManana = 0, gastoTarde = 0;

            Console.WriteLine();
            Console.WriteLine("                     ========================== IMPRIMIR GASTOS DE SUELDOS POR TURNOS ==========================");
            Console.WriteLine();

            Console.WriteLine("                   Ingrese sueldo de empleados del turno de la mañana: \n");
            for (int i = 0; i < turnoManana.Length; i++)
            {
                Console.Write($"                   Sueldo empleado {i+1}: ");
                turnoManana[i] = Math.Round(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.WriteLine("                   Ingrese sueldo de empleados del turno de la tarde: \n");
            for (int i = 0; i < turnoTarde.Length; i++)
            {
                Console.Write($"                   Sueldo empleado {i + 1}: ");
                turnoTarde[i] = Math.Round(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine();


            for (int i = 0; i < turnoManana.Length; i++)
            {
                gastoManana += turnoManana[i];
            }

            Console.Write($"                   Gastos del turno de la mañana: {gastoManana}");

            for (int i = 0; i < turnoTarde.Length; i++)
            {
                gastoTarde += turnoTarde[i];
            }
            Console.WriteLine();
            Console.Write($"                   Gastos del turno de la tarde: {gastoTarde}");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        public static void Matriz3x4()
        {
            int[,] matriz = new int[3,4];
            int posCero = 0;

            Console.WriteLine();
            Console.WriteLine("                     ======== MATRIZ 3 X 4 CON VALORES ENTEROS IMPRIMIR 1RA Y ULTIMA FILA Y LA 1RA COLUMNA ========");
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write($"                     Digite posicion [{i+1},{c+1}]: ");
                    matriz[i, c] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // Imprimir matriz completa
            Console.WriteLine($"                     Matriz completa: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write($"                   {matriz[i, c]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // Imprimir primera fila
            Console.Write($"                          Primera fila: ");
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.Write($" {matriz[posCero, i]} ");
            }

            Console.WriteLine();
            // Imprimir ultima fila
            Console.Write($"                           Ultima fila: ");
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.Write($" {matriz[matriz.GetLength(0)-1, i]} ");
            }

            Console.WriteLine();
            // Imprimir primera columna
            Console.WriteLine($"                       Primera columna: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"                                         {matriz[i,posCero]} ");
            }

            Console.WriteLine();
            Console.Write("                                    ===>> Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

    }
}
