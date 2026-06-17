using EspacioCalculadora;
using EspacioEmpleado;

//Interfaz para operar la calculadora
int opcion = 1;
double auxiliar;
Calculadora miCalculadora = new Calculadora();
do
{
    Console.WriteLine("Ingrese 0 para ver el dato guardado en la memoria");
    Console.WriteLine("Ingrese 1 para sumar un valor");
    Console.WriteLine("Ingrese 2 para restar un valor");
    Console.WriteLine("Ingrese 3 para multiplicar un valor");
    Console.WriteLine("Ingrese 4 para dividir un valor");
    Console.WriteLine("Ingrese 5 para limpiar la memoria");
    Console.WriteLine("Ingrese 6 para finalizar la calculadora");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 0:
            Console.WriteLine(miCalculadora.Dato);
        break;

        case 1:
            Console.WriteLine("Ingrese un valor para sumar:");
            auxiliar = double.Parse(Console.ReadLine());
            miCalculadora.Sumar(auxiliar);
        break;

        case 2:
            Console.WriteLine("Ingrese un valor para restar:");
            auxiliar = double.Parse(Console.ReadLine());
            miCalculadora.Restar(auxiliar);
        break;

        case 3:
            Console.WriteLine("Ingrese un valor para multiplicar:");
            auxiliar = double.Parse(Console.ReadLine());
            miCalculadora.Multiplicar(auxiliar);
        break;

        case 4:
            Console.WriteLine("Ingrese un valor para dividir:");
            auxiliar = double.Parse(Console.ReadLine());
            miCalculadora.Dividir(auxiliar);
        break;

        case 5:
            miCalculadora.Limpiar();
        break;

        case 6:
            opcion = 6;
        break;

        default:
            Console.WriteLine("Ingrese una opcion valida!");
        break;
    }
} while (opcion != 6);


//___________________________________________________________________
//___________________________________________________________________
//Parte del programa para trabajar en el ejercicio 2.2
//___________________________________________________________________
//___________________________________________________________________


const int empleadosACargar = 3;

Empleado[] empleados = new Empleado[empleadosACargar];

//Carga de empleados con peticion de datos, descomentar para probar
/*
for (int i = 0; i < empleadosACargar; i++)
{
    //Nombre empleado
    Console.WriteLine($"Ingrese el nombre del empleado {i+1}:");
    string NombreEmpleado = Console.ReadLine();

    //Apellido empleado
    Console.WriteLine($"Ingrese el apellido del empleado {i+1}:");
    string ApellidoEmpleado = Console.ReadLine();

    //Fecha de nacimiento empleado
    Console.WriteLine($"Ingrese la fecha de nacimiento del empleado {i+1} (formato: dd/MM/yyyy):");
    string FechaNacimientoEmpleado = Console.ReadLine();

    //Genero de forma aleatoria el estado civil del empleado
    Random rnd = new Random();
    int EnteroAleatorio = rnd.Next(0, 4);
    EstadoCivil EstadocivilEmpleado;
    switch (EnteroAleatorio)
    {
        case 0:
            EstadocivilEmpleado = EstadoCivil.Soltero;
        break;

        case 1:
            EstadocivilEmpleado = EstadoCivil.Casado;
        break;
        
        case 2:
            EstadocivilEmpleado = EstadoCivil.Viudo;
        break;

        default:
            EstadocivilEmpleado = EstadoCivil.Divorciado;
        break;
    }

    //Fecha de ingreso a empresa empleado
    Console.WriteLine($"Ingrese la fecha de ingreso a la empresa del empleado {i+1} (formato: dd/MM/yyyy):");
    string FechaIngresoEmpleado = Console.ReadLine();

    //Sueldo basico
    Console.WriteLine($"Ingrese el sueldo basico del empleado {i+1}:");
    double SueldoBasicoEmpleado = double.Parse(Console.ReadLine());

    //Genero de forma aleatoria el cargo del empleado
    
    Cargo CargoEmpleado;
    switch (EnteroAleatorio)
    {
        case 0:
            CargoEmpleado = Cargo.Auxiliar;
        break;

        case 1:
            CargoEmpleado = Cargo.Administrativo;
        break;
        
        case 2:
            CargoEmpleado = Cargo.Ingeniero;
        break;

        case 3:
            CargoEmpleado = Cargo.Especialista;
        break;

        default:
            CargoEmpleado = Cargo.Investigador;
        break;
    }

    empleados[i] = new Empleado(NombreEmpleado, ApellidoEmpleado, FechaNacimientoEmpleado, EstadocivilEmpleado, FechaIngresoEmpleado, SueldoBasicoEmpleado, CargoEmpleado);
}
*/

//Cargo los empleados con datos predeterminados, si se quiere ingresar datos comentar el codigo de abajo y descomentar el de arriba
empleados[0] = new Empleado("Juan", "Perez", "09/07/1995", EstadoCivil.Soltero, "17/06/2026", 1000000, Cargo.Administrativo);
empleados[1] = new Empleado("Pepito", "Juarez", "09/07/1995", EstadoCivil.Casado, "17/06/2026", 1000000, Cargo.Ingeniero);
empleados[2] = new Empleado("Luis", "Rodriguez", "09/07/1995", EstadoCivil.Divorciado, "17/06/1990", 1000000, Cargo.Especialista);

//Muestro los salarios
Console.WriteLine($"Salario 1: ${empleados[0].CalcularSalario()}");
Console.WriteLine($"Salario 2: ${empleados[1].CalcularSalario()}");
Console.WriteLine($"Salario 3: ${empleados[2].CalcularSalario()}");

//Muestro el monto total en concepto de salarios
Console.WriteLine($"Monto total en concepto de salarios: ${empleados[0].CalcularSalario() + empleados[1].CalcularSalario() + empleados[2].CalcularSalario()}");

