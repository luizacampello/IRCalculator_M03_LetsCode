using IRCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public class ExemptionAliquot : Aliquot
    {
        public ExemptionAliquot()
        {
            superiorLimit = 22847.76;
            taxAliquot = 0;
            deduction = 0;
        }
        
    }
}
