using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            CCard bitch = new CCard("Simon", null);
            Console.WriteLine(bitch.GetName());
        }
    }
}
