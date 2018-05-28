using Edu.Mzt.Partners.Interfaces.MosadKita;
using Edu.Mzt.Partners.Interfaces.Talmid;
using PartnerApi.AppCode;
using System.Web.Http;

namespace PartnerApi.Controllers
{
    [AuthorizeCallerByHeader()]
    [RoutePrefix ("v1.0/MosadNofications")]
    public class MosadNoficationsController : ApiController
    {
        
        [HttpPost]       
        [Route("MosadInfo")]
        public IHttpActionResult MosadInfo([FromBody] MosadKita data)
        {
            // save the data to the db here..   
            return Ok(data);
        }


        //[HttpPost]
        //[Route("MosadMegama")]
        //public IHttpActionResult MosadMegama([FromBody] TalmidShibutz data)
        //{
        //    var tz = data.MISPAR_ZEHUT;
        //    return Ok(data);
        //}
        
    }
}