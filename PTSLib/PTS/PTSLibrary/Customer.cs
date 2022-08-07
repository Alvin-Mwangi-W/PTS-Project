using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    [Serializable]
    public class Customer : User
    {

        public Customer() { }

        public Customer(String name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
