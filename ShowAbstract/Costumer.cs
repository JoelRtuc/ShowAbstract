using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAbstract
{
    internal class Costumer : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("Costumer Menu");
        }
    }
}
