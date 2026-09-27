using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] notas = { 8, 6, 9, 7, 5 };

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }

        int sumaNotas = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            sumaNotas += notas[i];
        }
        double promedio = (double)sumaNotas / notas.Length;
        Console.WriteLine(promedio);

        int max = notas[0];
        int min = notas[0];
        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > max) max = notas[i];
            if (notas[i] < min) min = notas[i];
        }
        Console.WriteLine(max);
        Console.WriteLine(min);

        int[] arrayInvertido = new int[notas.Length];
        for (int i = 0; i < notas.Length; i++)
        {
            arrayInvertido[i] = notas[notas.Length - 1 - i];
        }
        foreach (int n in arrayInvertido)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        int contadorMayores7 = 0;
        foreach (int n in notas)
        {
            if (n > 7) contadorMayores7++;
        }
        Console.WriteLine(contadorMayores7);

        List<string> tareas = new List<string>();
        tareas.Add("Estudiar C#");
        tareas.Add("Hacer TP7");
        tareas.Add("Subir a GitHub");

        tareas.Remove("Estudiar C#");
        Console.WriteLine(tareas.Count);

        foreach (string tarea in tareas)
        {
            Console.WriteLine(tarea);
        }

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        for (int i = 0; i < 3; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();

        int buscar = 7;
        bool existe = false;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] == buscar)
            {
                existe = true;
                break;
            }
        }
        Console.WriteLine(existe);
    }
}