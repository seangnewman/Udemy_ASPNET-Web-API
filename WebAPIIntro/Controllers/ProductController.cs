﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIIntro.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/product")]
        public string Get()
        {
            return "laptop";
        }
    }
}
