using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class CampoTexto : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return !string.IsNullOrEmpty(Valor);
        }
    }
}
