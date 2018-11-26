using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTest
{
    public class Customer:EntityBase
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
    }
}
