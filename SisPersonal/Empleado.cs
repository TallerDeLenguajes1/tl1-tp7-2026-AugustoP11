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

    public int CalcularAntiguedad()
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

    private double calcularAdicional()
    {
        int Antiguedad = CalcularAntiguedad();
        double adicional;

        if (Antiguedad < 20)
        {
            adicional = this.sueldoBasico * 0.01 * Antiguedad;
        } else
        {
            adicional = this.sueldoBasico * 0.25;
        }

        //Si es ingeniero o especialista se aumenta 50%
        switch (this.cargo)
        {
            case Cargo.Ingeniero:
            case Cargo.Especialista:
                adicional *= 1.5;
            break;
            default:
            break;
        }

        //Si es casado se suma $150.000
        switch (this.estadoCivil)
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
        double salario = this.sueldoBasico + calcularAdicional();
        
        return salario;
    }
}