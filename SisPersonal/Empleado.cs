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
        int Antiguedad = this.fechaIngresoAEmpresa.Year - DateTime.Today.Year;

        if (Antiguedad > 0)
        {
            return Antiguedad;
        } else
        {
            return 1;
        }
    }

    public int Edad()
    {
        int Edad = fechaDeNacimiento.Year;
        return Edad;
    }

    public int TiempoParaJubilacion()
    {
        int TiempoRestante = 65 - (DateTime.Now.Year - fechaDeNacimiento.Year);

        if (TiempoRestante > 0)
        {
            return TiempoRestante;
        }
        else
        {
            return 0;
        }
    }

    
}