using System;

namespace Laboratornaya3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Stop = true;
            int chislo;

            while(Stop)
            {
                Console.WriteLine("Введите любое число из этого примера J = - sin^3(y)/1*3 + sin^5(x^2)/3*5 - sin^7(y^3)/5*7+sin^9(x^4)/7*9 >");
                chislo = Convert.ToInt32(Console.ReadLine());

                if (chislo == 0)
                    break;
                if (chislo == 6)
                    break;
            }
        }
    }
}
