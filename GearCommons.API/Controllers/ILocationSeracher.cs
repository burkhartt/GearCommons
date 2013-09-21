namespace GearCommons.API.Controllers {
	public interface ILocationSeracher {
		object Search(string query);
	}

	public class LocationSearcher : ILocationSeracher {
		public object Search(string query) {

			var url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=50&name=" + query + "&sensor=false&key=AddYourOwnKeyHere";
			return null;
		}
	}
}