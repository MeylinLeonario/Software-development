using Project_5;

Console.WriteLine("Ingrese dificultad");
int dificultad;
while (true)
{
    try
    {
        dificultad = Convert.ToInt32(Console.ReadLine());
        break;

    }
    catch
    {
        Console.WriteLine("La dificultad no es aceptada");
    }
}

Guess guess = new Guess();

Random random = new Random();


int numero;

while (true)
{
    switch (dificultad)
    {
        case 1:
            Console.WriteLine("Dificultad sencilla: números del 0 al 10");
            numero = random.Next(0,10);
            break;

        case 2:
            Console.WriteLine("Dificultad intermedia: números del 0 al 20");
            numero = random.Next(0,20);
            break;

        case 3:
            Console.WriteLine("Dificultad difícil: números del 0 al 30");
            numero = random.Next(0,30);
            break;

        default:
            Console.WriteLine("Ingrese una nueva dificultad, del 1 al 3");
            dificultad = Convert.ToInt32(Console.ReadLine());
            continue;
    }

    break;
}

guess.GuessNumber(numero);