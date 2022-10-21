using System.Web;
using System.Web.Mvc;

namespace HTTP_5112_Assign2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
