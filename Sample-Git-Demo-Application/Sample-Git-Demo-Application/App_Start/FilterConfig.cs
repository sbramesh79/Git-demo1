using System.Web;
using System.Web.Mvc;

namespace Sample_Git_Demo_Application
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
