using System;

namespace ProyectoEquipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Equipo ===\n");

            // Alumno 1 agrega su método aquí
            Saludar("Profesor");

            // Alumno 2 agrega su método aquí
            MostrarFecha();

            // Alumno 3 agrega su método aquí
            Suma(10, 5);

            Console.WriteLine("\n=== Fin del programa ===");
        }

        // Método base - creado por el profesor
        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}!");
        }

        // Alumno 1 puede modificar este método
        static void MostrarFecha()
        {
            Console.WriteLine($"Fecha actual: {DateTime.Now.ToShortDateString()}");
        }

        // Alumno 2 puede modificar este método
        static void Suma(int a, int b)
        {
            Console.WriteLine($"Suma de {a} + {b} = {a + b}");
        }

        // Alumno 3 puede agregar métodos nuevos aquí

    }
}
