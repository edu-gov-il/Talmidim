﻿using Edu.Mzt.Partners.Interfaces.MosadKita;
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
    [RoutePrefix ("v1.0/MosadNotifications")]
    public class MosadNoficationsController : ApiController
    {
        // CHECK 
        [HttpPost]
        [Route("MosadInfo")]
        public IHttpActionResult MosadInfo([FromBody] MosadInfo data)
        {
            // save the data to the db here..   
            return Ok(data);
        }

        [HttpPost]
        [Route("KitaInfo")]
        public IHttpActionResult KitaInfo([FromBody] KitaInfo data)
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
        public IHttpActionResult KitaMichsa([FromBody] KitaMichsa data)
        {
            // save the data to the db here..   
            return Ok(data);
        }
        

    }
}