using System;

namespace BVKMN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter sum of a loan:");
            var sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter months:");
            var months = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter interest rate (%):");
            var interestRate = Convert.ToDouble(Console.ReadLine());

            var pmt = FinancialFunctions.Pmt(interestRate / 100, months, sum);
            var rate = FinancialFunctions.Rate(months, pmt, sum);
            var effect = FinancialFunctions.Effect(rate);

            Console.WriteLine($"BVKKMN: {effect * 100}");
            Console.ReadKey();
        }
    }
}
