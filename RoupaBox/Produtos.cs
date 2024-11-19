using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class ExibirProdutos
    {
        List<ProdutosCad> listaProdutos = new List<ProdutosCad>();
        public ProdutosCad cadProduto()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos");

            Console.WriteLine("\nDigite a Descrição do Produto: ");
            string descPro = Console.ReadLine();

            var Produto = new ProdutosCad(descPro);

            Console.WriteLine("\nDigite a Marca do Produto: ");
            string marcaPro = Console.ReadLine();
            Produto.marcaPro = marcaPro;

            Console.WriteLine("\nDigite o Tamanho do Produto: ");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro;

            Console.WriteLine("\nDigite a Cor do Produto: ");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro;

            Console.WriteLine("\nDigite a Categoria do Produto: ");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;

            Console.WriteLine("\nDigite o Valor do Produto: ");
            while (!double.TryParse(Console.ReadLine(), out double valPro))
            {
                Console.WriteLine("Valor Inválido, Tente Novamente.\n");
                Console.WriteLine("\nDigite o Valor do Produto: ");
                Produto.valPro = valPro;
            }

            Console.WriteLine("\nDigite o Peso do Produto: ");
            while (!double.TryParse(Console.ReadLine(), out double pesoPro))
            {
                Console.WriteLine("Valor Inválido, Tente Novamente.\n");
                Console.WriteLine("\nDigite o Peso do Produto: ");
                Produto.pesoPro = pesoPro;

                listaProdutos.Add(Produto);

                Console.WriteLine("\nProduto cadastrado com sucesso!!!");

                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"Descrição: {produto.descPro}, " + $"Valor: {produto.valPro}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();

                Console.Clear();

                ExibirCabecalho variavelcabecalho = new ExibirCabecalho();
                variavelcabecalho.Cabecalho();

                ExibirMenu variavelmenu = new ExibirMenu();
                ExibirProdutos varPro = new ExibirProdutos();

                return Produto;
            }
        }
    }
}
