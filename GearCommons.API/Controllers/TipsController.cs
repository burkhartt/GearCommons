using System;
using System.Web.Http;

namespace GearCommons.API.Controllers {
	public class TipsController : ApiController {
		private readonly IRepository<Guide> guideRepository;

		public TipsController(IRepository<Guide> guideRepository) {
			this.guideRepository = guideRepository;
		}

		//POST api/guides/6EF5F556-9461-497E-A3E4-C5663022B0EC/tips
		public void Post(Guid id, string tip) {
			guideRepository.GetById(id).AddTip(tip);
		}
	}
}