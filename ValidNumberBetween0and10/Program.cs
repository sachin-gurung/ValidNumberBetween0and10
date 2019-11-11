using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidNumberBetween0and10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number between 0 and 10: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= 10)
            {
                Console.WriteLine("Valid number");
            }
            else
                Console.WriteLine("Invalid number");
            Console.ReadLine();
        }
    }
}
/* 
Result 1: 
Enter a number between 0 and 10: 5
Valid number

Press any key to continue . . .

Result 2: 
Enter a number between 0 and 10: 56
Invalid number

Press any key to continue . . .
*/
