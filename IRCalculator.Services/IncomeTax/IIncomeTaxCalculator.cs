using IRCalculator.Domain;

namespace IRCalculator.Services.IncomeTax
{
    public interface ITaxCalculator
    {
        public double TaxCalculation(IncomeDTO income);

        public void PrintAliquotTable();

    }
}