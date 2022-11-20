using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    internal class Client
    {
        int ClientID;
        string name, surname;
        decimal clientBalance;

        public Client(int clientID, string name, string surname, decimal clientBalance)
        {
            ClientID1 = clientID;
            this.Name = name;
            this.Surname = surname;
            this.ClientBalance = clientBalance;
        }

        public int ClientID1 { get => ClientID; set => ClientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public decimal ClientBalance { get => clientBalance; set => clientBalance = value; }
    }
}
