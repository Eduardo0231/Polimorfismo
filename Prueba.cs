using System;
using System.Diagnostics;

public class Prueba { 

    static void Main(string[] args)
    {
        Console.WriteLine("Calculo de salarios de empleados\n");

        DocenteporHora docenteHora1 = new DocenteporHora("Juan Martinez", true, 120);
        DocenteFijo docenteFijo1 = new DocenteFijo("Maria Mercedes", true, 40000);
        EmpleadoAdministrativo administrativo1 = new EmpleadoAdministrativo("Paco Ramirez",
        false, 50000);

        Console.WriteLine($"Salario de {docenteHora1.Nombre} (Docente por Hora): {docenteHora1.CalcularSalario()} RD$\n");
        Console.WriteLine($"Salario de {docenteFijo1.Nombre} (Docente Fijo): {docenteFijo1.CalcularSalario()} RD$\n");
        Console.WriteLine($"Salario de {administrativo1.Nombre} (Administrativo): {administrativo1.CalcularSalario()} RD$\n");

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}