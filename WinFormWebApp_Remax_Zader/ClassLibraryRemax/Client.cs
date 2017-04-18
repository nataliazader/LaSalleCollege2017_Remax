using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRemax
{
    public class Client : Person
    {
        public string Comment {
            get; set;
        }

        public string IdAgent {
            get; set;
        }

        public string Role {
            get; set;
        }

        public Client():base() { }

        public Client(string id, string name, string phone, string email, string comment, string idAgent, string role):base(id,name,phone,email)
        {
            this.Comment = comment;
            this.IdAgent = idAgent;
            this.Role = role;
        }

        public Client(string name, string phone, string email, string comment, string idAgent, string role) : base(name, phone, email)
        {
            this.Comment = comment;
            this.IdAgent = idAgent;
            this.Role = role;
        }
    }
}
