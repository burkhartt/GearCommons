using System;
using System.Web.Http;

namespace GearCommons.API.Controllers {
	public class VoteController : ApiController {
		private readonly IRepository<Guide> guideRepository;

		public VoteController(IRepository<Guide> guideRepository) {
			this.guideRepository = guideRepository;
		}

		public void Up(Guid id) {
			var guide = guideRepository.GetById(id);
			guide.VoteUp();
			guideRepository.Save(guide);
		}

		public void Down(Guid id) {
			var guide = guideRepository.GetById(id);
			guide.VoteDown();
			guideRepository.Save(guide);
		}
	}
}