using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentname = "michael";
            displayMessage(12, studentname);
        }
        static private void displayMessage(double numberOfTimes, string name)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Hello World " + name);
            }

            name = "bob";

        }
    }
}
