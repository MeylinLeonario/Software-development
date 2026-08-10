
Console.WriteLine("Escribe un número: ");
int numero;
int numero2;
string operacion;
int res = 0;
try
{
    numero = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce un número válido.");
    numero = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("¿Qué operación deseas realizar? \n A. Suma \n B. Resta \n C. Multiplicación \n D. División");    

try
{
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    operacion = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    if (operacion != "A" && operacion != "B" && operacion != "C" && operacion != "D")
    {
        throw new FormatException();
    }
} catch (FormatException)
{
    Console.WriteLine("Por favor, introduce una letra válida.");
    operacion = Console.ReadLine();

}

Console.WriteLine("Escribe otro número: ");
try
{
    numero2 = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Por favor, introduce un número válido.");
    numero2 = Convert.ToInt32(Console.ReadLine());
}


if (operacion == "A")
{
    res = numero + numero2;
}
else if (operacion == "B")
{
    res = numero - numero2;
}
else if (operacion == "C")
{
    res = numero * numero2;
}
else if (operacion == "D")
{
    res = numero / numero2;
}

Console.WriteLine("El resultado es: " + res);