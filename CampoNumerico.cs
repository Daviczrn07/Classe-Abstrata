using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class CampoNumerico : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return int.TryParse(Valor, out _);
        }
    }
}


