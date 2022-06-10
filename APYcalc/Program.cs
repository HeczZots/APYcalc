using System;



namespace formula1
{
    class Program
    {
        public static void Main()
        {
            // profit = dep*((1+apy/duration)^period*duration)
            Console.WriteLine("enter your deposit");
            double dep = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your target APY in % like XX.XX");
            double apy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a  duration ");
            double duration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter reinvest periodicity");
            double period = Convert.ToDouble(Console.ReadLine());
            double a = period * duration;
            double b = 1 + apy / duration;
            double roe = dep * Math.Pow(b, a);
            for (int i = 1; i < duration; i++)
            {
                double roePY = dep * Math.Pow(( 1 + apy / i ), i);
                Console.WriteLine($"{i}-year-{roePY}\t");
            }
            Console.WriteLine($"{duration} years PNL={roe}\t") ;

        }
    }
}
