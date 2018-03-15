using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
//using System.Web.Mvc;

namespace PartnerApi.AppCode
{

    public class AuthorizeCallerByHeaderAttribute : AuthorizationFilterAttribute
    {
        const string TokenKey = "ApiToken";         // Web.config appsettings key to hold the token value 
        const string HeaderName = "CallerToken";    // the header name that holds the token 
        
        static string TokenValue = "";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            bool isOk = false;
            TokenValue = GetTokenValue(); 

            IEnumerable<string> headerValues;            
            if (actionContext.Request.Headers.TryGetValues(HeaderName, out headerValues))                
            {
                string HeaderToken = headerValues.First();
                if ( !string.IsNullOrEmpty(HeaderToken) && HashHelper.VerifyMd5Hash(TokenValue, HeaderToken))                
                    isOk = true;                 
            }
            if (!isOk)
            {
                // log it 
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Not allowed to access this api");
                
            }

            
        }

        private string GetTokenValue()
        {         
            if (string.IsNullOrEmpty(TokenValue))
            {
                TokenValue = ConfigurationManager.AppSettings[TokenKey];
                if (string.IsNullOrEmpty(TokenValue))
                    throw new ApplicationException("missing "+ TokenKey +" in appsettings");
            }           
            return TokenValue;
        }
    }

  
}