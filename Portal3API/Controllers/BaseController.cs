﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Portal3API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseController : ApiController
    {

    }
}
