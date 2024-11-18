using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Clientes
    {
        public void cadCliente() 
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o nome Completo do Cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine("\nDigite o CPF do Cliente: ");
            long cpfCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Telefone do Cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a Idade do Cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o E-mail do Cliente: ");
            string emailCli = Console.ReadLine();

            Console.WriteLine("\nDigite o Sexo do Cliente: ");
            string sexCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Rua / Avenida do Cliente: ");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\nDigite o complemento do Cliente: ");
            string compCli = Console.ReadLine();

            Console.WriteLine("\nDigite o numero do Cliente: ");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Bairro do Cliente: ");
            string bairCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Cidade do Cliente: ");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\nDigite o Estado do Cliente: ");
            string estCli = Console.ReadLine();

            Console.WriteLine("\nDigite o CEP do Cliente: ");
            long cepCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nCliente cadastrado com sucesso!");
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
