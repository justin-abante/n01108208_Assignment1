using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustinAbante.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {

            /// <summary>
            /// This method takes the input that user sets as the id and squares it 
            /// <example>GET api/Square/2</example>
            /// <returns>4</returns>
            /// </summary>


            return id * id;
        }
    }
}
