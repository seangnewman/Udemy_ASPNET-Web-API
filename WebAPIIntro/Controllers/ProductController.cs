using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIIntro.Controllers
{
    public class ProductController : ApiController
    {
        // Parameter Binding
        // Get - Single primitive paramter, multiple primitive parameters
        // Post - multiple primitive parameters, complex paramter, mixed parameters (primitive & complex parameters)
        // [FromUri]
        // [FromBody]


        //Action return type
        //voi d
        // primitive and complex types
        // HttpResponseMessage
        //IHttpActionResult

        //Request response data formats
        // headers - content type and accept
        //

        [Route("api/product")]
        public List<string> GetFormatters()
        {
            IList<string> formatters = new List<string>();

            foreach(var formatter in GlobalConfiguration.Configuration.Formatters)
            {
                formatters.Add(formatter.ToString());
            }

            return formatters.ToList();
        }

        //[Route("api/product")]
        //public string Get()
        //{
        //    return "laptop";
        //}

        [Route("api/product")]
        public string Get(int productId)
        {
            return "Single Primitive Parameter";
        }

        [Route("api/product")]
        public string Get(int productId, string productName, bool isAvailable)
        {
            return "Multiple Primitive Parameters";
        }

        [Route("api/product")]
        public string Post(int productId, string productName, bool isAvailable)
        {

            // logic here
            return "Multiple Primitive Parameters";
        }

        //[Route("api/product")]
        //public string Post(Employee emp)
        //{

        //    // logic here
        //    return "Complex Parameter from Body";
        //}

        //[Route("api/product")]
        //public string Post(int empAge, Employee emp)
        //{

        //    // logic here
        //    return "Mixed primitive from uri  and Complex Parameter from Body";
        //}

        //[Route("api/product")]
        //public string Post([FromBody] int empAge, [FromUri] Employee emp)
        //{

        //    // logic here
        //    return "Mixed primitive from uri  and Complex Parameter from Body";
        //}

        //[Route("api/product")]
        //public Employee Post( int empAge,  Employee emp)
        //{

        //    // logic here

        //    return emp;
        //}

        //[Route("api/product")]
        //public HttpResponseMessage  Post(int empAge, Employee emp)
        //{

        //    // logic here

        //    return Request.CreateResponse(HttpStatusCode.Created, emp);
        //}

        [Route("api/product")]
        public IHttpActionResult Post(int empAge, Employee emp)
        {

            // logic here

           // return Ok();
            return Ok(emp);
        }

        //Get   - primitive & complex parameters will be extracted query string
        //Post  - primitive parameters from query string, complex from body
        //Put - primitive parameters from query string, complex from body
        //Delete - primitive & complex parameters will be extracted query string
    }

    public class Employee
    {
        public int empID { get; set; }
        public string name { get; set; }
    }
}
