using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleCharacter
{
    public class ToggleCharacter
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Toggle String:");

            string inputString = Console.ReadLine();
            ToggleClassService togClass = new ToggleClassService();

            string toggleString = togClass.ToggleCase(inputString);

            Console.WriteLine("Toggle string is : {0}", toggleString);
        }
    }

}
