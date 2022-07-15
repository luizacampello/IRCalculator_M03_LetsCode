namespace IRCalculator.Domain
{
    public class IncomeDTO
    {
        public double Value { get; private set; }

        public IncomeDTO(double income)
        {
            Value = income;
        }
    }
}