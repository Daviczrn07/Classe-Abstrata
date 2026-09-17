using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class Drone : ICamera, IVoavel
    {
        public void TirarFoto()
        {
            Console.WriteLine("Tirando foto panorâmica...");
        }

        public void Decolar()
        {
            Console.WriteLine("Drone decolando verticalmente...");
        }

        public void Pousar()
        {
            Console.WriteLine("Drone pousando suavemente...");
        }
    }
}

