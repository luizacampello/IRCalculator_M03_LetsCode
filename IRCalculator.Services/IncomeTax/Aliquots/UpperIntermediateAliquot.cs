using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public class UpperIntermediateAliquot : Aliquot
    {
        public UpperIntermediateAliquot()
        {
            inferiorLimit = 45012.61;
            superiorLimit = 55976.16;
            taxAliquot = 0.225;
            deduction = 7633.51;
        }
        

    }
}
