using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores_en_tiempo_de_ejecucion
{
        class Program
        {
            static int[] SumarVectores(int[] vector1, int[] vector2)
            {
                int[] resultado = new int[vector1.Length];
                for (int i = 0; i < vector1.Length; i++)
                {
                    resultado[i] = vector1[i] + vector2[i];
                }
                return resultado;
            }

            static void Main(string[] args)
            {
                int[] tamanosVectores = { 10, 100, 1000, 10000 };

                foreach (int tamaño in tamanosVectores)
                {
                    int[] vector1 = new int[tamaño];
                    int[] vector2 = new int[tamaño];

                    for (int i = 0; i < tamaño; i++)
                    {
                        vector1[i] = i;
                        vector2[i] = i + tamaño;
                    }

                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int[] resultado = SumarVectores(vector1, vector2);
                    stopwatch.Stop();

                    TimeSpan tiempoEjecucion = stopwatch.Elapsed;
                    Console.WriteLine($"Tamaño del vector: {tamaño}, Tiempo de ejecución: {tiempoEjecucion.TotalMilliseconds} milisegundos");
                }
            }
        }
}