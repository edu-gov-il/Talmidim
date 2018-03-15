using PartnerApi.AppCode;
using System.Web;
using System.Web.Mvc;

namespace PartnerApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());            
        }
    }
}
