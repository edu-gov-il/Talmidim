using System.Web.Http;
using PartnerApi.AppCode;
using Edu.Mzt.Partners.Interfaces.Talmid;


//TalmidNotifications/TalmidInfo
//TalmidNotifications/TalmidKesher
//TalmidNotifications/TalmidGormeiKesher
//TalmidNotifications/TalmidShibutz
//TalmidNotifications/HatzharatMenahel
//TalmidNotifications/HatzharatMutav

namespace PartnerApi.Controllers
{    
    [RoutePrefix("v1.0/TalmidNotifications")]
    [AuthorizeCallerByHeader()]
    public class TalmidNoficationsController : ApiController
    {
        [HttpPost]
        [Route("TalmidInfo")]
        public IHttpActionResult TalmidInfo([FromBody] TalmidInfo data)
        {           
            // save the data to the db here 
            return Ok(data);
        }

        [HttpPost]
        [Route("TalmidShibutz")]
        public IHttpActionResult TalmidShibutz([FromBody] TalmidShibutz data)
        {            
            // save the data to the db here 
            return Ok(data);
        }
        

        [HttpPost]
        [Route("TalmidKesher")]
        public IHttpActionResult TalmidKesher([FromBody] TalmidKesher data)
        {   
            // save the data to the db here 
            return Ok(data);
            //return BadRequest();
            //return NotFound();
        }


        [HttpPost]
        [Route("TalmidGormeyKesher")]
        public IHttpActionResult TalmidGormeyKesher([FromBody] TalmidGormeyKesher data)
        {
            // save the data to the db here 
            return Ok(data);
            
        }

        [HttpPost]
        [Route("HatzharatMenahel")]
        public IHttpActionResult HatzharatMenahel([FromBody] HatzharatMenahel data)
        {
            // save the data to the db here 
            return Ok(data);
            
        }

        [HttpPost]
        [Route("HatzharatMutav")]
        public IHttpActionResult HatzharatMutav([FromBody] HatzharatMutav data)
        {
            // save the data to the db here 
            return Ok(data);

        }



    }
}