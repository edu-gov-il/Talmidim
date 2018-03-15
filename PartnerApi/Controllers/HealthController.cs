using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PartnerApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix ("v1.0/health")]
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("isAlive")]
        public IHttpActionResult isAlive()
        {
            return Ok("HealthCheck : is a live, time :" + DateTime.Now.ToString());
        }

        [HttpGet]
        [Route("isDbAlive")]
        public IHttpActionResult isDbAlive()
        {
            // make a test connetion to the db and check the environment 
            // you can make this method async and await a call here 
            return Ok("HealthCheck : Service & Db is a live, time :" + DateTime.Now.ToString());
        }


        [HttpGet]
        [Route("TestData")]
        public IHttpActionResult TestData()
        {
            var list =  new string[] { "value11", "value22", DateTime.Now.ToString() };
            return Ok(list );
        }



    }
}
