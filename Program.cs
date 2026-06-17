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

