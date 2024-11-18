using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Produto
    {
        public void cadProduto() 
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos");

            Console.WriteLine("\nDigite a Marca do Produto: ");
            string marcaPro = Console.ReadLine();

            Console.WriteLine("\nDigite o Tamanho do Produto: ");
            string tamPro = Console.ReadLine();

            Console.WriteLine("\nDigite a Cor do Produto: ");
            string corPro = Console.ReadLine();

            Console.WriteLine("\nDigite a Categoria do Produto: ");
            string descPro = Console.ReadLine();

            Console.WriteLine("\nDigite a Descrição do Produto: ");
            string catPro = Console.ReadLine();

            Console.WriteLine("\nDigite o Valor do Produto: ");
            while (!double.TryParse(Console.ReadLine(), out double valPro))
            {
                Console.WriteLine("Valor Inválido, Tente Novamente.\n");
                Console.WriteLine("\nDigite o Valor do Produto: ");
            }

            Console.WriteLine("\nDigite o Peso do Produto: ");
            while (!double.TryParse(Console.ReadLine(),out double pesoPro))
            {
                Console.WriteLine("Valor Inválido, Tente Novamente.\n");
                Console.WriteLine("\nDigite o Peso do Produto: ");
            }

            Console.WriteLine("\nProduto cadastrado com sucesso!!!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();

            Console.Clear();

            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.cabecalho();

            Menu variavelmenu = new Menu();
            variavelmenu.menu();
        }
    }
}
