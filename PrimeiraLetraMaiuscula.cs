using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque {
    internal class PrimeiraLetraMaiuscula {
        public static string Primeira_LetraMaiuscula(string str)
        {
            if( string.IsNullOrEmpty(str) ) 
                return str;
            char[] letras = str.ToCharArray();
            letras[0] = char.ToUpper(letras[0]);
            return new string(letras);
        }
    }
}
