using System;
using System.Collections.Generic;

namespace GearCommons.API.Controllers {
	public class Guide {
		public double Latitude { get; set; }
		public string LatitudeDirection { get; set; }
		public double Longitude { get; set; }
		public string LongitudeDirection { get; set; }
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public IEnumerable<string> Tips { get; set; }
		public IEnumerable<string> Images { get; set; }
		public decimal Rating { get; set; }
	}
}