using IRCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public abstract class Aliquot
    {
        public double inferiorLimit { get; protected set; }
        public  double superiorLimit { get; protected set; }
        public double taxAliquot { get; protected set; }
        public double deduction { get; protected set; }

        public Aliquot Next { get; protected set; }
                
        public void SetNext(Aliquot next)
        {
            Next = next;
        }

        public virtual double TaxValue(IncomeDTO income)
        {
            if (income.Value <= superiorLimit)
            {
                return (taxAliquot * income.Value) - deduction;
            }
            else
            {
                return Next.TaxValue(income);
            }
        }


    }
}
