using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class ExibirClientes
    {
        List<ClientesCad> listaClientes = new List<ClientesCad>();
        public void cadCliente() 
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");

            var Clientes = new ClientesCad(nomeCli);

            Console.WriteLine("\nDigite o nome Completo do Cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine("\nDigite o CPF do Cliente: ");
            string cpfCli = Console.ReadLine();

            if(cpfCli.Length !=11)
            {
                Console.WriteLine("Erro");
            }
            else
            {
                Console.WriteLine("Certo");
            }

            Console.WriteLine("\nDigite o Telefone do Cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a Idade do Cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o E-mail do Cliente: ");
            string emailCli = Console.ReadLine();
            while (!emailCli.Contains("@"))
            {
                Console.WriteLine("O endereço de e-mail não é Válido, tente novamente...");
                emailCli = Console.ReadLine();
            }
            

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

            listaClientes.Add(Clientes);

            Console.WriteLine("\nCliente cadastrado com sucesso!");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Nome: {cliente.nomeCli}, " + $"CPF: {cliente.cpfCli}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();

            Console.Clear();

            ExibirCabecalho variavelcabecalho = new ExibirCabecalho();
            variavelcabecalho.Cabecalho();

            ExibirMenu variavelmenu = new ExibirMenu();
            ExibirClientes varCli = new ExibirClientes();

            return Clientes;
        }
    }
}
