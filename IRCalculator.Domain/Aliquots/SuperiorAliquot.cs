using IRCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public class SuperiorAliquot : Aliquot
    {

        public SuperiorAliquot()
        {
            inferiorLimit = 55976.16;
            taxAliquot = 0.275;
            deduction = 10432.32;
        }

        public override double TaxValue(IncomeDTO income)
        {
            return (taxAliquot * income.Value) - deduction;            
        }

    }
}
