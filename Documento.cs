using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Abstrata
{
    internal class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("SALVANDO O DOCUMENTO EM FORMATO.DOC");

        }
    }
}
