// Inicializamos las variables
double numero1;
string operacion;
double resultado;
string unidad;
string unidadSalida;

Console.WriteLine("¿Qué conversión desea realizar? \n A. Temperatura \n B. Distancia \n C. Peso \n D. Tiempo");
try
{
    operacion = Console.ReadLine();
    if (operacion != "A" && operacion != "B" && operacion != "C" && operacion != "D")
    {
        throw new FormatException();
    }
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce una letra válida.");
    operacion = Console.ReadLine();
}

Console.WriteLine("Escribe un número: ");
try
{
    numero1 = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce un número válido.");
    numero1 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Escribe una unidad: ");
try
{
    unidad = Console.ReadLine();
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce una unidad válida.");
    unidad = Console.ReadLine();
}

Console.WriteLine("Escribe la unidad de salida: ");
try
{
    unidadSalida = Console.ReadLine();
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce una unidad de salida válida.");
    unidadSalida = Console.ReadLine();
}

ElegirFuncion(operacion, numero1);

void ElegirFuncion(string operacion, double numero1)
{
    if (operacion == "A")
    {
        Temperatura();
    }
    else if (operacion == "B" || operacion == "C")
    {
        DistanciaAndPeso();
    }
    else if (operacion == "D")
    {
        Tiempo();
    }
}

void Temperatura()
{
    if ((unidad == "C" || unidad == "Celsius" )&& (unidadSalida == "F" || unidadSalida== "Fahrenheit"))
    {
        resultado = (numero1 * 9 / 5) + 32;
        Console.WriteLine($"{numero1}°C son {resultado}°F");
    }
    else if ((unidad == "F" || unidad == "Fahrenheit" ) && (unidadSalida == "C" || unidadSalida== "Celsius"))
    {
        resultado = (numero1 - 32) * 5 / 9;
        Console.WriteLine($"{numero1}°F son {resultado}°C");
    }
    else
    {
        Console.WriteLine("Conversión no válida.");
    }
}

void DistanciaAndPeso()
{
    if ((unidad == "KM" && unidadSalida == "M" ) || (unidad == "KG" && unidadSalida == "G"))
    {
        resultado = numero1 * 1000;
    }
    if ((unidad == "M" && unidadSalida == "KM") || (unidad == "G" && unidadSalida == "KG"))
    {
        resultado = numero1 / 1000;
    }
}

void Tiempo()
{
    if (unidad == "S" && unidadSalida == "M")
    {
        resultado = numero1 / 60;
    }
    if (unidad == "M" && unidadSalida == "S")
    {
        resultado = numero1 * 60;
    }
}