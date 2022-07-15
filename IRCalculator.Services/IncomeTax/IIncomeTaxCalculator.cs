using IRCalculator.Domain;

namespace IRCalculator.Services.IncomeTax
{
    public interface IIncomeTaxCalculator
    {
        public double CalculateTax(IncomeDTO income);

        public void PrintAliquotTable();

    }
}