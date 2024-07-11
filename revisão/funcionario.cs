using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace revisão
{
    public class funcionario:Pessoa
    {

        private int matricula { get; set; }
        public string placaveiculo { get; set; }

        public int GetName(int m)
        {
            return matricula;
           
        }

        public bool verificarVeiculo(Automovel automovel)
        {
            if (automovel.Placa.Length == 7)
            {
                Console.WriteLine(true);
                return false;
               
            }
            else
            {
                Console.WriteLine(false);
                return false;

            }
            return true;
        }

    }
}
