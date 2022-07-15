using IRCalculator.Domain;
using IRCalculator.Services.IncomeTax.Aliquots;

namespace IRCalculator.Services.IncomeTax
{
    public class IncomeTax : IIncomeTaxCalculator
    {
        private Aliquot a1;
        private Aliquot a2;
        private Aliquot a3;
        private Aliquot a4;
        private Aliquot a5;


        public IncomeTax()
        {
            a1 = new ExemptionAliquot();
            a2 = new LowerIntermediateAliquot();
            a3 = new IntermediateAliquot();
            a4 = new UpperIntermediateAliquot();
            a5 = new SuperiorAliquot();

            a1.SetNext(a2);
            a2.SetNext(a3);
            a3.SetNext(a4);
            a4.SetNext(a5);
        }


        public double CalculateTax(IncomeDTO income)
        {
            return a1.TaxValue(income);
        }

        public void PrintTaxesTable()
        {
            Aliquot currentAliquot = a1;

            Console.WriteLine("      Faixas de valor($)      |  Alíquota  |  Dedução");
            while (currentAliquot.Next != null)
            {
                Console.WriteLine($"R$ {String.Format("{0:0.00}", currentAliquot.inferiorLimit),-10} - R$ {String.Format("{0:0.00}", currentAliquot.superiorLimit),-10} | {currentAliquot.taxAliquot,-10} | {currentAliquot.deduction, -10}");
                currentAliquot = currentAliquot.Next;
            }
            Console.WriteLine($"Acima de R$ {String.Format("{0:0.00}", currentAliquot.inferiorLimit), -16}  | {currentAliquot.taxAliquot,-10} | {currentAliquot.deduction,-10}");
        }

    }
}
