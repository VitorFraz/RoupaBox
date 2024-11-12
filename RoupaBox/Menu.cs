using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Menu
    {
        public void menu() 
        {
            Console.WriteLine("Digite 0 para sair");
            Console.WriteLine("Digite 1 Cadastro de Clientes");
            Console.WriteLine("Digite 2 Listar Clientes");
            Console.WriteLine("Digite 3 Cadastro de Produtos");
            Console.WriteLine("Digite 4 Listar Produtos");
            Console.WriteLine("\nDigite a opção escolhida: ");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {

                case 0:
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"
██╗░░░██╗██╗░░░░░░██╗░░░░░░░██╗░░░  ███████╗██╗░░░░░░██╗░░░░░░░██╗██╗
██║░░░██║██║░░░░░░██║░░██╗░░██║░░░  ██╔════╝██║░░░░░░██║░░██╗░░██║██║
╚██╗░██╔╝██║░░░░░░╚██╗████╗██╔╝░░░  █████╗░░██║░░░░░░╚██╗████╗██╔╝██║
░╚████╔╝░██║░░░░░░░████╔═████║░██╗  ██╔══╝░░██║░░░░░░░████╔═████║░╚═╝
░░╚██╔╝░░███████╗░░╚██╔╝░╚██╔╝░╚█║  ██║░░░░░███████╗░░╚██╔╝░╚██╔╝░██╗
░░░╚═╝░░░╚══════╝░░░╚═╝░░░╚═╝░░░╚╝  ╚═╝░░░░░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝");
                    Console.ResetColor();
                    break;

                case 1:
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case 2:
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case 3:
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                case 4:
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }
        }
    }
}
