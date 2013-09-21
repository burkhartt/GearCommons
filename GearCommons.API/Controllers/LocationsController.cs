using System;
using System.Web.Helpers;
using System.Web.Http;
using Newtonsoft.Json;

namespace GearCommons.API.Controllers {
	public class LocationsController : ApiController {
		// GET api/locations
		public dynamic Get() {
			var locations = new[] {
				new Location {Latitude = 42.3581, LatitudeDirection = "N", Longitude = 71.0636, LongitudeDirection = "W", Id = new Guid("C4F4ADEF-641C-4098-9BB2-E13AB44DA9C7")}, 
				new Location {Latitude = 52.2050, LatitudeDirection = "N", Longitude = 0.1190, LongitudeDirection = "E", Id = new Guid("655904A9-DAB1-4098-94B2-37F3BA0AF227")}
			};
			return Json.Encode(locations);
		}

		// GET api/values/5
		public dynamic Get(Guid id) {
			return new Location {Latitude = 42.3581, LatitudeDirection = "N", Longitude = 71.0636, LongitudeDirection = "W", Id = new Guid("C4F4ADEF-641C-4098-9BB2-E13AB44DA9C7")};
		}

		// POST api/values
		public void Post([FromBody]string value) {

		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/values/5
		public void Delete(int id) {
		}
	}
}