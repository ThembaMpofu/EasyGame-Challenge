using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    internal class Tranaction
    {
        int transactionId, clientID;
        decimal amount;
        string transactionTypeName, comment;

        public Tranaction(int transactionId, int clientID, decimal amount, string transactionTypeName, string comment)
        {
            this.transactionId = transactionId;
            this.clientID = clientID;
            this.amount = amount;
            this.transactionTypeName = transactionTypeName;
            this.comment = comment;
        }

        public int TransactionId { get => transactionId; set => transactionId = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string TransactionTypeName { get => transactionTypeName; set => transactionTypeName = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
