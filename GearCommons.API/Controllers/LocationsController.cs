using System.Web.Http;

namespace GearCommons.API.Controllers {
	public class LocationsController : ApiController {
		// GET api/locations
		public dynamic Get() {
			return new[] {
				new Location { Latitude = 42.3581, LatitudeDirection = "N", Longitude = 71.0636, LongitudeDirection = "W"},
				new Location { Latitude = 52.2050, LatitudeDirection = "N", Longitude = 0.1190, LongitudeDirection = "E"}
			};
		}

		// GET api/values/5
		public dynamic Get(int id) {
			//var asdf = new Blah { Hmm = "Ok"};
			//return Json.Encode(asdf);
			return null;
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