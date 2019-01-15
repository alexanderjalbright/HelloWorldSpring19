using System;

namespace HelloWorldSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;
            string strTip = "Yes";
            int intTipPercent;
            float fTotal; //floats are for num with decimal points
            float fTip;
            bool bTip = true; //hot and cold, yes and no, in and out, up and down 
            

            Console.WriteLine("What is your name?");
            strName = Console.ReadLine(); //Retrieve input from console

            Console.WriteLine("Hello, " + strName + "!");

            if (strName.Equals("Alex")) //comparing two strings
            {
                Console.WriteLine("The creators name is "+ strName.ToUpper() +", too!"); //convert string to uppercase
            }

            Console.WriteLine("Welcome to Tip Calculator!");

            Console.WriteLine("To start things off, would you like to leave a tip?");
            strTip = Console.ReadLine();

        
            if(strTip.StartsWith("Y"))
            {
                Console.WriteLine("Great! Let's get started.");
              
            } else
            {
                bTip = false;
            }

            Console.WriteLine("How much was your total bill?");

            


           
        }
    }
}
