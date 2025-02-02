using System;

public class DocenteFijo : Empleado
{
    public int SueldoFijo { get; set; }

    public DocenteFijo(string nombre, bool alcanzoMeta, int sueldoFijo) :
        base(nombre, alcanzoMeta)
    {
        SueldoFijo = sueldoFijo;
    }

    public override decimal CalcularSalario()
    {
        return AlcanzoMeta ? SueldoFijo : SueldoFijo / 2;
    }
}