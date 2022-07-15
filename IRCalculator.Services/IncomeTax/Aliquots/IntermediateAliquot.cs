using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator.Services.IncomeTax.Aliquots
{
    public class IntermediateAliquot : Aliquot
    {
        public IntermediateAliquot() 
        {
            inferiorLimit = 33919.81;
            superiorLimit = 45012.60;
            taxAliquot = 0.150;
            deduction = 4257.57; 
        }


    }
}
