using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using Newtonsoft.Json;

namespace GearCommons.API.Controllers {
	public class GuidesController : ApiController {
		private IEnumerable<Guide> guides;

		public GuidesController() {
			guides = new[] {
				new Guide {
					Latitude = 42.3581, 
					LatitudeDirection = "N", 
					Longitude = 71.0636, 
					LongitudeDirection = "W", 
					Id = new Guid("C4F4ADEF-641C-4098-9BB2-E13AB44DA9C7"),
					Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis lacinia ligula. Duis faucibus, felis eu convallis commodo, ante eros vulputate ligula, sed imperdiet nunc dolor eu purus. Praesent turpis dui, euismod viverra semper eget, convallis ut nisl. Proin suscipit felis eu purus semper posuere. Vivamus sollicitudin dui id nulla sagittis, ornare interdum felis mattis. Nunc tempor nunc in tempus tincidunt. Pellentesque egestas elit a congue dictum. Aenean sapien lacus, euismod in porta ac, vulputate id ipsum. Donec ultrices massa ut mi dictum malesuada. Vivamus vitae volutpat erat, non luctus eros. In id viverra lorem, a eleifend tortor. Curabitur vel elit vitae felis semper lobortis quis id lorem.",
					Images = new [] {
						"http://www.flickr.com/photos/cubagallery/8991328288/",
						"http://www.flickr.com/photos/doug88888/5909752823/",
						"http://www.flickr.com/photos/doug88888/5912999510/"
					},
					Name = "A Mountain",
					Rating = 4.283M,
					Tips = new []{
						"Don't go alone",
						"Take supplies",
						"Take water"
					}
				},
				new Guide {
					Latitude = 46.3581, 
					LatitudeDirection = "N", 
					Longitude = 77.0636, 
					LongitudeDirection = "W", 
					Id = new Guid("38D3BD78-F972-4928-A609-7FC3E3A6336B"),
					Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis lacinia ligula. Duis faucibus, felis eu convallis commodo, ante eros vulputate ligula, sed imperdiet nunc dolor eu purus. Praesent turpis dui, euismod viverra semper eget, convallis ut nisl. Proin suscipit felis eu purus semper posuere. Vivamus sollicitudin dui id nulla sagittis, ornare interdum felis mattis. Nunc tempor nunc in tempus tincidunt. Pellentesque egestas elit a congue dictum. Aenean sapien lacus, euismod in porta ac, vulputate id ipsum. Donec ultrices massa ut mi dictum malesuada. Vivamus vitae volutpat erat, non luctus eros. In id viverra lorem, a eleifend tortor. Curabitur vel elit vitae felis semper lobortis quis id lorem.",
					Images = new [] {
						"http://www.flickr.com/photos/yury-prokopenko/4529889410/",
						"http://www.flickr.com/photos/46758577@N02/4964465857/",
					},
					Name = "The desert",
					Rating = 4.283M,
					Tips = new []{
						"Beware of dog",
						"Don't get sick?"
					}
				}
			};
		}

		// GET api/locations
		public dynamic Get() {
			return Json.Encode(guides);
		}

		// GET api/values/5
		public dynamic Get(Guid id) {
			return Json.Encode(guides.Single(x => x.Id == id));
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

	//public class Guide {
	//	public IEnumerable<string> Comments { get; set; }
	//	// ratings
	//	//location
	//}
}