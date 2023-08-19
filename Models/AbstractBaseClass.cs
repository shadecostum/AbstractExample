using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    //abstract ekyword must assign here class
    // abstract class is not full abstract  class normal methods and variables can declare
    //abstract methods contain abstract class should declare all child class of abstract class
    //child calling abstract function it should ovveride used
    abstract class AbstractBaseClass
    {
        public abstract string Name { get; set; }
        public int RollNo { get; set; }

        public AbstractBaseClass() 
        {

            Console.WriteLine("base abstract class Constructor");
           
        }

        public abstract void PrintDetails();
       // public abstract void WriteDetails(); 
        

        public string NormalFunction(string name)
        {
            return name;
        }
    }
}
