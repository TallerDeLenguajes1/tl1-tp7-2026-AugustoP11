namespace EspacioEmpleado;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private EstadoCivil estadoCivil;
    private DateTime fechaIngresoAEmpresa;
    private double sueldoBasico;
    private Cargo cargo;

    public Empleado(string nombre, string apellido, string fechaDeNacimiento, EstadoCivil estadoCivil, string fechaIngresoAEmpresa, double sueldoBasico, Cargo cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaDeNacimiento = DateTime.Parse(fechaDeNacimiento, System.Globalization.CultureInfo.InvariantCulture);
        this.estadoCivil = estadoCivil;
        this.fechaIngresoAEmpresa = DateTime.Parse(fechaIngresoAEmpresa, System.Globalization.CultureInfo.InvariantCulture);
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public int Antiguedad()
    {
        DateTime Antiguedad = DateTime.Parse(this.fechaIngresoAEmpresa - DateTime.Today);

        
        return 0;
    }
}