namespace MzansiPayrollSystem
{
    public class PayrollCalculator
    {
        public const double HourlyRate = 950.0;

        public double CalculateGrossPay(double hoursWorked)
        {
            return HourlyRate * hoursWorked;

            // Example: 40 x  950 = 38,000
        }

        // Method 2 Calculae UIF Deduction
        // Formula: Gross Pay x 1% = Gross Pay x 0.01

        // Takes: grossPay | Returns UIF Amount

        public double CalculateUIFDeduction(double grossPay)
        {
            return grossPay * 0.01;
        }

        // Method 3 Calculate PAYE Deduction 
        // Formula : Gross Pay x 0.0575 x Dependents)) x 0.25
        // Takes: grossPay, dependents
        //  Returns PAYE Amount

        public double CalculatePAYEDeduction(double grossPay, int numberOfdependents)
        {
            double DependateRebate = grossPay * 0.0575 * numberOfdependents;

            double taxableIncome = grossPay - DependateRebate;

            double paye = taxableIncome * 0.25;
            return paye;
        }

        // Method 4 Calculate Membership Fees
        // Formula: Gross Pay x 13% = Gross Pay x 0.13
        // -----------------------------------------------

        public double CalculateMembershipFee(double grossPay)
        {
            return grossPay * 0.13;
            // Example: 3800 x 0.13 = 4940.00
        }

        // Calculate TotalDeductions
        public double CalculateTotalDeductions(double uif, double paye, double membership)
        {
            return uif + paye + membership;
        }


        // -----------------------------------------------
        // Method 5 Calculate Net Pay
        // Formula: Gross Pay - UIF - PAYE - Membership Fees
        // Takes all four values and returns the final Net Pay
        // -----------------------------------------------



        public double CalculateNetPay(double grossPay, double uif, double paye, double membershipFees)
        {
            return grossPay - uif - paye - membershipFees;
            // Example: 38000 - 380 - 9500 - 4940 = 24270.50
        }
    }
}