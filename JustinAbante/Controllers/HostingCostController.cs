using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustinAbante.Controllers
{
    public class HostingCostController : ApiController
    {

        public IEnumerable<string> Get(int id)
        {
            /// <summary>
            /// This method returns the total cost of hosting and maintenance based on the number of fortnights (fortnight = 14 days) multiplied by $5.50 per fortnight with tax included
            /// </summary>
            /// <example>GET api/HostingCost/0 </example>
            /// <returns>
            /// <ArrayOfstring >
            /// < string > "1 fortnights at $5.50/FN = $5.50 CAD" </ string >
            /// < string > "HST 13% = $0.72 CAD" </ string >
            /// < string > "Total = $6.22 CAD" </ string >
            /// </ ArrayOfstring >
            /// </returns>
            

            int numberOfFortnights = id / 14 + 1;
            decimal costPerFortnight = 5.50M;
            decimal costPreTax = Math.Round(numberOfFortnights * costPerFortnight, 2);
            decimal tax = 0.13M;
            decimal additionalTax = Math.Round(costPreTax * tax, 2);
            decimal finalCost = Math.Round(additionalTax + costPreTax, 2);
            string quote = "\"";
            
            return new string[] { quote + numberOfFortnights + " fortnights at $5.50/FN = $" + costPreTax + " CAD" + quote, quote +  "HST 13% = $" + additionalTax + " CAD" + quote, quote +  "Total = $" + finalCost + " CAD" + quote};

        }
    }
}

