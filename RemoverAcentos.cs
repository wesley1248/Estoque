using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estoque {
    internal static class RemoverAcentos {
       public static string Remover (string texto) {
            string semAcentos = Regex.Replace(texto.Normalize(NormalizationForm.FormD), @"[^a-zA-Z0-9 ]+", "");
            return semAcentos.ToLower();
        } 
    }
}
