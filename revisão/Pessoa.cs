using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace revisão
{
    public class Pessoa
    {

        public string nome { get; set; }
        public Boolean contratar()
        {
            Console.WriteLine("contatado com sucesso");

            return true;
        }

    }
}
