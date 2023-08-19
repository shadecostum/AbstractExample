using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Animal : AbstractBaseClass
    {
        public override string Name { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine("Abstract ovveride function called in child class Animal");
            Console.WriteLine($"Animal Name : {Name}\n Animal No : {RollNo}");
        }
        public Animal() 
        {
            
            Console.WriteLine("Default constructor of animal child classs");
        }
        public Animal(string name,int newname)
        {
            this.Name = name;
            this.RollNo = newname;
           
        }


    }
}
