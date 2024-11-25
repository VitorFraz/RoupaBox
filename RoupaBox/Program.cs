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
            ExibirCabecalho variavelCabecalho = new ExibirCabecalho();
            variavelCabecalho.Cabecalho();

            ExibirClientes varCli = new ExibirClientes();
            ExibirProdutos varPro = new ExibirProdutos();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro, varCli);

        }
    }
}
