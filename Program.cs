using AbstractExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractExample obj=new AbstractExample(); cannot create direct object
           
            Console.WriteLine("================================================================");
            Animal animal = new Animal();
            animal.Name = "Lion";
            animal.RollNo = 1;
            animal.PrintDetails();

            Console.WriteLine("======================Parameterised ==========================================");
            Animal animal1 = new Animal("king",5);
            animal1.PrintDetails();
            Console.WriteLine("================================================================");
            string animalName= animal.NormalFunction("Tiger");
            Console.WriteLine(animalName);
            Console.WriteLine("==================For Rael Abstraction Done====================");
            AbstractBaseClass abstractBaseClass = new Animal();
            abstractBaseClass.PrintDetails();
            string animalName2=  abstractBaseClass.NormalFunction("Fox");
            Console.WriteLine(animalName2);
            Console.WriteLine("===================================================================");
            AbstractBaseClass fish= new Fish();
            fish.PrintDetails();





        }
    }
}
