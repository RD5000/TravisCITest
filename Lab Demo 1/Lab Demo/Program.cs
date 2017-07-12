using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////BASIC PROGRAMMIN 101 NERDS
            //int number;
            //double amount;
            //string text;
            //
            //number = 5;
            //amount = number;
            //number = (int)amount;
            //
            //text = number.ToString();
            //
            ////SWITCH STATEMENTS CAUSE IF STATMENTS ARE FOR BITCHES
            //switch (number)
            //{
            //    case 5:
            //        Console.WriteLine("This is 5");
            //        break;
            //    default:
            //        Console.WriteLine("Bleep");
            //        break;
            //}
            //
            ////SHITTY WHILE LOOPS HA.
            //while (number < 7)
            //{
            //    Console.WriteLine("TO INFIINITY, AND BEYOND");
            //    number++;
            //}
            //
            ////DO WHILE LOOPS NERD
            //do
            //{
            //    Console.WriteLine("Craww!");
            //    number++;
            //} while (number < 7);
            //
            ////NEVER DO WHAT IS SHOWN BELOW YOU FUCKTARD.
            //int i = 0;
            //for (; ; )
            //{
            //    if (i == 10) break;
            //    Console.WriteLine("For loops for Lyfeee i = {0}", i);
            //    i++;
            //}
            //Console.WriteLine("This is x-erino cappachino i = {0}", i);
            //
            ////MOTHER FUCKER THIS IS HOW YOU FOR LOOP
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("What a real for loop looks like bitch. i = {0}", i);
            //}
            //
            //FOREACH LOOPS BITCH
            //int[] myNumbers;
            //myNumbers = new int[3];
            //myNumbers[0] = 1;
            //myNumbers[1] = 2;
            //myNumbers[2] = 4;
            //
            //foreach (var item in myNumbers)
            //{
            //    Console.WriteLine("element is {0}", item);
            //}
            int[][] table;
            table = new int[1][,];
            table[0] = new int[23];
            table[1] = new int[3];
            foreach (var item in table)
            {
                Console.WriteLine("element is {0}", item);
            }
                
            
        }
    }
}
