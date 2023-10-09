using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //declare variables
            string name = "Leo";
            int age =21;

            //initialisation
            name = "Leo";
            

            //what will be seen on console
            Console.WriteLine("The was once a girl caled"+ name);
            Console.WriteLine(name + "was"+age +"of age.");
            Console.WriteLine(name + "Really never liked her name.");

            //change variable values
            age = 26;
            name = "Kamo";
            Console.WriteLine("At age"+ age + "she changed her name to"+ name);

            //to freeze the cosole
            Console.ReadLine();

            



        }
    }
}
