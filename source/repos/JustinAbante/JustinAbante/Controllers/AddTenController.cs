using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JustinAbante.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            /// <summary>
            /// This method adds 10 to whatever number the user sets as the id
            /// <example>GET api/AddTen/21</example>
            /// </summary>
            /// <returns>31</returns>

            int a = 10;
            return id + a;
        }

    }
}