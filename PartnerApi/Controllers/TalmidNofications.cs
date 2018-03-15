using System.Web.Http;
using PartnerApi.AppCode;
using Edu.Mzt.Partners.Interfaces.Talmid;

namespace PartnerApi.Controllers
{
    
    [RoutePrefix("v1.0/TalmidNofications")]
    [AuthorizeCallerByHeader()]
    public class TalmidNoficationsController : ApiController
    {
        
        [HttpPost]
        [Route("TalmidShibutz")]
        public IHttpActionResult TalmidShibutz([FromBody] TalmidShibutz data)
        {
            var tz = data.MISPAR_ZEHUT;
            // save the data to the db here 
            return Ok(data);
        }
        

        [HttpPost]
        [Route("TalmidKesher")]
        public IHttpActionResult TalmidKesher([FromBody] TalmidShibutz data)
        {           
            var tz = data.MISPAR_ZEHUT;
            // save the data to the db here 
            return Ok(data);
        }



    }
}