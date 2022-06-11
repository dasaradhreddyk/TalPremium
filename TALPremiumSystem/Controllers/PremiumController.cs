using Microsoft.AspNetCore.Mvc;
using TALPremiumSystem.Core.Models;
using TALPremiumSystem.Core.Service;

namespace TALPremiumSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumController : ControllerBase
    {
      
        private readonly ILogger<PremiumController> _logger;
        private readonly IPremiumCalculationService1 _srv;

        public PremiumController(ILogger<PremiumController> logger, IPremiumCalculationService1 svc)
        {
            _logger = logger;
            _srv = svc;
        }

        [HttpGet]
        public IEnumerable<double> Get(string name, int age,double amount , string occupation)
        {
           UserDetails details = new UserDetails(name,occupation,age,amount);          
            double retrunValue = _srv.calculate(details);
            yield return retrunValue;
        }
    }
}