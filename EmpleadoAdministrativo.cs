using System;

public class EmpleadoAdministrativo : Empleado
{
    public int Salario { get; set; }

    public EmpleadoAdministrativo(string nombre, bool alcanzoMeta, int salario)
        : base(nombre, alcanzoMeta)
    {
        Salario = salario;
    }

    public override decimal CalcularSalario()
    {
        return AlcanzoMeta ? Salario : Salario / 2;
    }
}