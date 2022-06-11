using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALPremiumSystem.Core.Models;

namespace TALPremiumSystem.Core.Service
{
    public class PremiumCalculationService : IPremiumCalculationService1
    {
        public double calculate(UserDetails userDetails)
        {
            //Death Premium = (Death Cover amount *Occupation Rating Factor *Age) / 1000 * 12
            return Math.Round(userDetails.Age * userDetails.OccupationRatingFactor * userDetails.DeathCoverAmount / 1000 * 12,2);
        }
    }
}
