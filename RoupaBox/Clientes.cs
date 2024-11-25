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
        public ClientesCad CadCliente() 
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");

            Console.WriteLine("\nDigite o nome Completo do Cliente: ");
            string nomeCli = Console.ReadLine();

            var Cliente = new ClientesCad(nomeCli);

            Console.WriteLine("\nDigite o CPF do Cliente: ");
            string cpfCli = Console.ReadLine();
            Cliente.cpfCli = cpfCli;

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
            Cliente.sexCli = sexCli;

            Console.WriteLine("\nDigite a Rua / Avenida do Cliente: ");
            string ruaCli = Console.ReadLine();
            Cliente.ruaCli = ruaCli;

            Console.WriteLine("\nDigite o complemento do Cliente: ");
            string compCli = Console.ReadLine();
            Cliente.compCli = compCli;

            Console.WriteLine("\nDigite o numero do Cliente: ");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Bairro do Cliente: ");
            string bairCli = Console.ReadLine();
            Cliente.bairCli = bairCli;

            Console.WriteLine("\nDigite a Cidade do Cliente: ");
            string cidCli = Console.ReadLine();
            Cliente.cidCli = cidCli;

            Console.WriteLine("\nDigite o Estado do Cliente: ");
            string estCli = Console.ReadLine();
            Cliente.estCli = estCli;

            Console.WriteLine("\nDigite o CEP do Cliente: ");
            long cepCli = long.Parse(Console.ReadLine());

            listaClientes.Add(Cliente);

            Console.WriteLine("\nCliente cadastrado com sucesso!");


            return Cliente;
        }
        public void listarCLientes()
        {
            Console.Clear();
            Console.WriteLine("Lista de Clientes Cadastrados");
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
        }
    }
}