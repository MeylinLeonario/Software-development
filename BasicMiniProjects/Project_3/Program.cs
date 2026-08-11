
string generadorContraseniaSegura()
{
    Random rnd = new Random();
    int numero = rnd.Next(10,30);

    const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstvwxyz!#$%&/()=?*[]_:;";

    string token = "";

    for (int i = 0; i < numero; i++)
    {
        int indice = rnd.Next(alfabeto.Length);
        token += (alfabeto[indice]);
    }

    return token;
    
}

string contrasenia= generadorContraseniaSegura();
Console.WriteLine(contrasenia);