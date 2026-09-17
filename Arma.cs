using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    abstract class Arma
    {
        public string Nome { get; set; }
        public int DanoBase { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"Arma: {Nome} | Dano Base: {DanoBase}");
        }

        public abstract double CalcularAtaqueCritico();
    }
}
