using System;

namespace HelloWorldSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            MessinRound();
            
        }
        static void MessinRound()
        {
            //Variable Declaration
            double dblTipPercent;
            double dblTotal;
            double dblTip;

            Console.WriteLine("");
            Console.WriteLine("******** Tip Calculator ********");
            Console.WriteLine("");

            //Determine bill total
            Console.WriteLine("How much was the total bill?");
            dblTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much would you like to tip? 15, 18, or 20 percent?");
            dblTipPercent = Convert.ToDouble(Console.ReadLine());
            dblTipPercent = dblTipPercent / 100;

            switch (dblTipPercent)
            {
                case 0.15:
                    dblTip = 15;
                    break;
                case 0.18:
                    dblTip = 18;
                    break;
                case 0.20:
                    dblTip = 20;
                    break;
                default:
                    dblTip = 15;
                    break;
            }

            //Do maths
            dblTipPercent = dblTipPercent / 100;
            dblTip = dblTotal * dblTipPercent;

            //print tip amount
            Console.WriteLine("Tip: " + dblTip);
            

        }
    }
}
