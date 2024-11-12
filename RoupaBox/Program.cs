using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.cabecalho();

            Menu variavelmenu = new Menu();
            variavelmenu.menu();
        }
    }
}
