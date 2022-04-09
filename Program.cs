using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferramenta f1 = new Ferramenta("Martelo", 100);
            f1.ExibirDados();
            Ferramenta f2 = new Ferramenta("Martelete", 100);
            f2.ExibirDados();
            Console.ReadKey();
        }
    }
}
