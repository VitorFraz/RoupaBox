using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class ClientesCad
    {
        public ClientesCad(string cli) 
        {
            nomeCli = cli;
        }
        public string nomeCli { get; set;}
        public string cpfCli { get; set;}
        public string telCli { get; set;}
        public string idadeCli { get; set; }
        public string sexCli { get; set; }
        public string ruaCli { get; set; }
        public string compCli { get; set; }
        public string numCli { get; set; }
        public string bairCli { get; set; }
        public string cidCli { get; set; }
        public string estCli { get; set; }
        public string cepCli { get; set; }
    }
}
