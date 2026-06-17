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

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public EstadoCivil EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngresoAEmpresa { get => fechaIngresoAEmpresa; set => fechaIngresoAEmpresa = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargo Cargo { get => cargo; set => cargo = value; }

    public Empleado(string nombre, string apellido, string fechaDeNacimiento, EstadoCivil estadoCivil, string fechaIngresoAEmpresa, double sueldoBasico, Cargo cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaDeNacimiento = DateTime.Parse(fechaDeNacimiento, System.Globalization.CultureInfo.InvariantCulture);
        this.EstadoCivil = estadoCivil;
        this.FechaIngresoAEmpresa = DateTime.Parse(fechaIngresoAEmpresa, System.Globalization.CultureInfo.InvariantCulture);
        this.SueldoBasico = sueldoBasico;
        this.Cargo = cargo;
    }

    public int CalcularAntiguedad()
    {
        int Antiguedad = FechaIngresoAEmpresa.Year - DateTime.Today.Year;

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
        int Edad = FechaDeNacimiento.Year;
        return Edad;
    }

    public int TiempoParaJubilacion()
    {
        int TiempoRestante = 65 - (DateTime.Now.Year - FechaDeNacimiento.Year);

        if (TiempoRestante > 0)
        {
            return TiempoRestante;
        }
        else
        {
            return 0;
        }
    }

    private double calcularAdicional()
    {
        int Antiguedad = CalcularAntiguedad();
        double adicional;

        if (Antiguedad < 20)
        {
            adicional = SueldoBasico * 0.01 * Antiguedad;
        } else
        {
            adicional = SueldoBasico * 0.25;
        }

        //Si es ingeniero o especialista se aumenta 50%
        switch (Cargo)
        {
            case Cargo.Ingeniero:
            case Cargo.Especialista:
                adicional *= 1.5;
            break;
            default:
            break;
        }

        //Si es casado se suma $150.000
        switch (EstadoCivil)
        {
            case EstadoCivil.Casado:
                adicional += 150000;
            break;
            default:
            break;
        }

        return adicional;

    }

    public double CalcularSalario()
    {
        double salario = SueldoBasico + calcularAdicional();

        return salario;
    }
}