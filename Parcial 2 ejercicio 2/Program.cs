﻿using System.Text.RegularExpressions;

public class Program

{
    private static string continuar;

    private static void Main(string[] args)

    {

        //ingresar las notas de varios estudiantes, calcular su promedio y luego clasificar a cada estudiante en diferentes categorías de desempeño académico. Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes

        do

        {
            List<double> notas = new List<double>();
            string continuar;

            Console.Write("Porfavor ingresa la cantidad de estudinates");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)

            {

                Console.Write($"Ingresa la nota del estudiante {i + 1}:");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);

            }

            double promedio = CalcularPromedio(notas);
            string categoria = ClasificarDesempeno(promedio);

            Console.WriteLine($"El promedio del gurpo es: {promedio:F2} - Categoria: {categoria}");
            Console.Write("¿Quiere ingresar un nuevo grupo de estudiantes? (s/n): ");
            continuar = Console.ReadLine().ToLower();

               } while (continuar == "s");
    }

    static double CalcularPromedio(List<double> notas)
    {
        double suma = 0;
        foreach (var nota in notas)
        {
            suma += nota;
        }
        return suma / notas.Count;
    }
    static string ClasificarDesempeno(double promedio)
    {
        if (promedio >= 4.5)
            return "Excelente";
        else if (promedio >= 4.0)
            return "Sobresaliente";
        else if (promedio >= 3.5)
            return "Bueno";
        else
            return "Insuficiente";
    }
}












        
