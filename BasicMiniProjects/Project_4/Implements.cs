using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_4
{
    public class Implements : Interface
    {
        public bool ValidarContrasenia(string contrasenia)
        {
            int cantidad = contrasenia.Length;
            string letras = "ABCDEFGHIJKLMNOPQRSTVWXYZabcdefghijklmnopqrstvwxyz1234567890@!#$%&/()=?";
            int match = 0;
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < letras.Length; j++)
                    {
                        if (contrasenia[i] == letras[j])
                        {
                            match +=1;
                        }
                    }
            }

            if (match == cantidad)
            {
                Console.Write("True");
                return true;
            } else
            {
                Console.Write("False");
                return false;
            }
        }
    }
}