using IRCalculator.Domain;

namespace IRCalculator.Services
{
    public interface IIncomeTaxCalculator
    {
        public double CalculateTax(IncomeDTO income);

        public void PrintTaxesTable();

    }
}