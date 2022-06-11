using TALPremiumSystem.Core.Models;
using TALPremiumSystem.Core.Service;
using Xunit;

namespace TALPremiumSystem.Test
{
    public class Tests
    {       

        [Fact]
        public void TestCalculation()
        {
            UserDetails user = new UserDetails("Sam","Doctor",35,1000);
            PremiumCalculationService srv = new PremiumCalculationService();
            var premium = srv.calculate(user);
            Assert.Equals(premium, 35 * 1 * 1000 /1000 * 12);
        }
    }
}