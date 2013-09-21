using System;
using System.Web.Http;

namespace GearCommons.API.Controllers {
	public class ImagesController : ApiController {
		private readonly IRepository<Guide> guideRepository;

		public ImagesController(IRepository<Guide> guideRepository) {
			this.guideRepository = guideRepository;
		}

		//POST api/guides/76C94E09-3206-4B86-AAF0-B3F5B26D7FEA/iamges
		public void Post(Guid id, string url) {
			guideRepository.GetById(id).AddImage(url);
		}
	}
}