using System;
using System.Web.Helpers;
using System.Web.Http;

namespace GearCommons.API.Controllers {
	public class GuidesController : ApiController {
		private readonly IRepository<Guide> guideRepository;

		public GuidesController(IRepository<Guide> guideRepository) {
			this.guideRepository = guideRepository;
		}

		// GET api/guides
		public dynamic Get() {
			return Json.Encode(guideRepository.GetAll());
		}

		// GET api/guides/4AF75A7D-E289-45EF-A09A-D12ADC94E9A1
		public dynamic Get(Guid id) {
			return Json.Encode(guideRepository.GetById(id));
		}

		// POST api/guides
		public void Post([FromBody] Guide guide) {
			guideRepository.Save(guide);
		}		

		// DELETE api/guides/EC81DEAA-CB2A-4175-9B7A-ABABA6F15264
		public void Delete(Guid id) {
			guideRepository.Delete(id);
		}
	}
}