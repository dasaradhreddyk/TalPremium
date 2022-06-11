using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALPremiumSystem.Core.Builder
{
    public static  class GetRatingFactorcs
    {
        public static   double GetRatingFactorcsValue(string occupation)
        {
            string categpry = Builder.GetRatingFactorcs.GetCategory(occupation);

            switch (categpry)
            {
                case "Light Manual":
                        return 1.50;
                case "Professional":
                        return 1.0;
                case "White Collar":
                        return 1.25;
                case "Heavy Manual":
                    return 1.75;               

            }
            return 0;

        }
        public static string  GetCategory(string occupation)
        {
            switch (occupation)
            {
                case "Doctor":
                    return "Professional";
               
                case "Cleaner":
                    return "Light Manual";
                case "Author":
                    return "White Collar";
                case "Farmer":
                    return "Heavy Manual";
                case "Mechanic":
                     return "Heavy Manual";
                case "Florist":
                    return "Light Manual";

            }
            return "";

        }
    }
}
