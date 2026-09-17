using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("SALVANDO A FOTO EM FORMATO.JPG");
        }
    }
}
