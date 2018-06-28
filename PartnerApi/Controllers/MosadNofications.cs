using Edu.Mzt.Partners.Interfaces.MosadKita;
using Edu.Mzt.Partners.Interfaces.Talmid;
using PartnerApi.AppCode;
using System.Web.Http;

//MosadNotifications/KitaInfo
//MosadNotifications/MoadInfo
//MosadNotifications/MegamaInfo
//MosadNotifications/KitaMichsa



namespace PartnerApi.Controllers
{
    [AuthorizeCallerByHeader()]
    [RoutePrefix ("v1.0/MosadNofications")]
    public class MosadNoficationsController : ApiController
    {
        
        //[HttpPost]       
        //[Route("MosadInfo")]
        //public IHttpActionResult MosadInfo([FromBody] MosadKita data)
        //{
        //    // save the data to the db here..   
        //    return Ok(data);
        //}

        [HttpPost]
        [Route("KitaInfo")]
        public IHttpActionResult KitaInfo([FromBody] MosadKita data)
        {
            // save the data to the db here..   
            return Ok(data);
        }

        [HttpPost]
        [Route("MegamaInfo")]
        public IHttpActionResult MegamaInfo([FromBody] MegamaInfo data)
        {
            // save the data to the db here..   
            return Ok(data);
        }

        [HttpPost]
        [Route("KitaMichsa")]
        public IHttpActionResult KitaMichsa([FromBody] Michsa data)
        {
            // save the data to the db here..   
            return Ok(data);
        }
        

    }
}