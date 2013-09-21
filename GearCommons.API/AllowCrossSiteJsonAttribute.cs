using System.Web.Http.Filters;
using ActionFilterAttribute = System.Web.Mvc.ActionFilterAttribute;

namespace GearCommons.API {
	public class AllowCrossSiteJsonAttribute : ActionFilterAttribute {
		public void OnActionExecuted(HttpActionExecutedContext actionExecutedContext) {
			if (actionExecutedContext.Response == null) return;
			actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
		}
	}
}