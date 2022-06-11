using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALPremiumSystem.Core.Models
{
    public class UserDetails
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public double DeathCoverAmount { get; set; }
        public double Age { get; set; }
        public double OccupationRatingFactor { get; set; }
        public UserDetails ( string name,string Occupation,double age,double DeathCoveramout   )
        {
            OccupationRatingFactor =  Builder.GetRatingFactorcs.GetRatingFactorcsValue(Occupation);
            Age = age;
            DeathCoverAmount = DeathCoveramout;
            Name = Name;
            Occupation = Occupation;
        }
    }
}
