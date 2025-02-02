using System;

public class DocenteporHora : Empleado
{
    public const int TarifaHora = 800;
    public int HorasTrabajadas { get; set; }

    public DocenteporHora(string nombre, bool alcanzoMeta, int horasTrabajadas)
        : base(nombre, alcanzoMeta)
    {
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaHora;
    }
}