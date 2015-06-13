using reCAPTCHA.Web.Demo.Helpers;
using System.Web;
using System.Web.Mvc;

namespace reCAPTCHA.Web.Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CompressFilter());
        }
    }
}