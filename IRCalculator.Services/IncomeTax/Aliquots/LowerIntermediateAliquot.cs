using IRCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public class LowerIntermediateAliquot : Aliquot
    {
        public LowerIntermediateAliquot()
        {
            inferiorLimit = 22847.77;
            superiorLimit = 33919.80;
            taxAliquot = 0.075;
            deduction = 1713.58;
        }
        


        
    }
}
