using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustinAbante.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {

            /// <summary>
            /// This method applies four mathematical operators (division, multiplication, subtraction & addition) to the input the user sets as the id 
            /// <example>GET api/NumberMachine/5</example>
            ///   /// <returns>15</returns>
            /// </summary>


            return (id * 5) / 2 + 6 - 3;

        }
    }
}
