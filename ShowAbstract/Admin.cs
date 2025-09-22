using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAbstract
{
    public class Admin : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("Admin Menu");
        }
    }
}
