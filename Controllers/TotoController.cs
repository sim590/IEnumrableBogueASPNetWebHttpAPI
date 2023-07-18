using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Toto.Controllers
{
    public class TotoController : ApiController
    {
        [HttpGet]
        [ActionName("Toto")]
        public IEnumerable<string> Toto()
        {
            yield return "";
        }
    }
}
