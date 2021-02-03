using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustinAbante.Controllers
{
    /// <summary>
    /// This method returns "Hello World" when receiving a post request
    /// <example>POST api/Greeting </example>
    /// </summary>
    /// <returns>["Hello World!"]</returns>
    public class GreetingController : ApiController
    {

        /// <summary>
        /// This method returns "Hello World" when receiving a post request
        /// <example>POST api/Greeting </example>
        ///  /// <returns>["Hello World!"]</returns>
        /// </summary>

        /// 
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }

        /// <summary>
        /// This method return "Greetings to" followed by the number set by the user in the url
        /// <example>GET api/Greeting/3</example>
        /// </summary>
        /// <returns>"Greetings to 3 people!"</returns>
       
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }

    }
}
