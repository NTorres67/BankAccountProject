using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class ClientInformation
    {
        //// fields
        private string clientName;
        private string clientAddress;
        private string clientEmailAddress;


        //// Properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }

        public string ClientAddress
        {
            get { return this.clientAddress; }
            set { this.clientAddress = value; }
        }

        public string ClientEmailAddress
        {
            get { return this.clientEmailAddress; }
            set { this.clientEmailAddress = value; }
        }

        //// Constructors
        public ClientInformation()
        {
            this.clientName = "Name: Emmalani Bryan";
            this.clientAddress = "Street Address: 123 Beagle-Corgi Lane, Elyria, OH  44035";
            this.clientEmailAddress = "Email: EBryan@gmail.com";

        }

        public ClientInformation(string clientName, string clientAddress, string clientEmailAddres)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientEmailAddress = clientEmailAddress;
        }


        //// Method
        




        //// 

    }

}
