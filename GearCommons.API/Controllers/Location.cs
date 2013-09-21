using System;

namespace GearCommons.API.Controllers {
	public class Location {
		public double Latitude { get; set; }
		public string LatitudeDirection { get; set; }
		public double Longitude { get; set; }
		public string LongitudeDirection { get; set; }
		public Guid Id { get; set; }
	}
}