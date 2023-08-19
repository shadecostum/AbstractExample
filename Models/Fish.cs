using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Fish : AbstractBaseClass
    {
        public override string Name { get ; set ; }

        public override void PrintDetails()
        {
            Console.WriteLine("fish class ");
        }
    }
}
