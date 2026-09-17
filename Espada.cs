using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class Espada : Arma
    {
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 2;
        }
    }
}
