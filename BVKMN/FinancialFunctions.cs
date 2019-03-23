using Excel.FinancialFunctions;

namespace BVKMN
{
    static class FinancialFunctions
    {
        public static double Pmt(double interestRate, int months, double sum)
        {
            return Financial.Pmt(interestRate / 12, months, sum * -1, 0, PaymentDue.BeginningOfPeriod);
        }

        public static double Rate(int months, double pmt, double sum)
        {
            return Financial.Rate(months, pmt, sum * -1, 0, PaymentDue.BeginningOfPeriod);
        }

        public static double Effect(double rate)
        {
            return Financial.Effect(rate * 12, 12);
        }
    }
}
