using System.Collections.ObjectModel;
using System.Net.Http;

namespace GearCommons.API {
	public class HandlerConfig {
		public static void RegisterHandlers(Collection<DelegatingHandler> handlers) {
			handlers.Add(new CorsMessageHandler());
		}
	}
}