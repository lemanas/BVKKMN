using System;
using System.Collections.Generic;
using BVKMN.Models;

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

            List<Payment> payments = PaymentsScheduler.GetPaymentsSchedule(sum, months, interestRate, pmt);

            Console.WriteLine($"BVKKMN: {effect * 100}");

            Console.WriteLine();
            Console.WriteLine("Payments schedule:");
            Console.WriteLine();

            for (int i = 0; i < payments.Count; i++)
            {
                Console.WriteLine($"{payments[i].PaymentNumber} \t {payments[i].Installment} \t {payments[i].Interest} \t {payments[i].Loan} \t {payments[i].Balance}");
            }

            Console.ReadKey();
        }
    }
}
