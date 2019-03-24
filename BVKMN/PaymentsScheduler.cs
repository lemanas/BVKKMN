using System.Collections.Generic;
using BVKMN.Models;

namespace BVKMN
{
    static class PaymentsScheduler
    {
        public static List<Payment> GetPaymentsSchedule(double sum, int months, double interestRate, double pmt)
        {
            var schedule = new List<Payment>();

            for (int i = 0; i < months; i++)
            {
                double previousBalance = i > 0 ? schedule[i - 1].Balance : sum;
                double interest = previousBalance * (interestRate / 100 / 12);
                double loan = pmt - interest;

                Payment payment = new Payment
                {
                    PaymentNumber = i + 1,
                    Installment = pmt,
                    Interest = interest,
                    Loan = loan,
                    Balance = previousBalance - loan
                };

                schedule.Add(payment);
            }

            return schedule;
        }
    }
}
