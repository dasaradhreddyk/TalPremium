using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALPremiumSystem.Core.Models;

namespace TALPremiumSystem.Core.Service
{
    public  interface IPremiumCalculationService1
    {
        public double calculate(UserDetails userDetails);
    }
}
