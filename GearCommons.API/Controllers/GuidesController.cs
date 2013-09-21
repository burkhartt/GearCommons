using System;
using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using Newtonsoft.Json;

namespace GearCommons.API.Controllers {
	public class GuidesController : ApiController {
		private readonly IRepository<Guide> guideRepository;
		private readonly ILocationSeracher locationSeracher;

		public GuidesController(IRepository<Guide> guideRepository, ILocationSeracher locationSeracher) {
			this.guideRepository = guideRepository;
			this.locationSeracher = locationSeracher;
		}

		// GET api/guides
		public dynamic Get() {
			//var results = locationSeracher.Search("Outdoor activities near Boston, MA");
			return JsonConvert.SerializeObject(guideRepository.GetAll());			
		}

		// GET api/guides/4AF75A7D-E289-45EF-A09A-D12ADC94E9A1
		public dynamic Get(Guid id) {
			return JsonConvert.SerializeObject(guideRepository.GetById(id));
		}

		// POST api/guides
		public void Post([FromBody] Guide guide) {
			guideRepository.Save(guide);
		}

		// DELETE api/guides/EC81DEAA-CB2A-4175-9B7A-ABABA6F15264
		public void Delete(Guid id) {
			guideRepository.Delete(id);
		}

		[HttpGet]
		public dynamic Search(double miles, double latitude, double longitude) {
			var guides = guideRepository.GetAll();
			var guidesInRadius = guides.Where(x => x.IsWithinMiles(5, latitude, longitude));
			return JsonConvert.SerializeObject(guidesInRadius);
		}				
	}
}