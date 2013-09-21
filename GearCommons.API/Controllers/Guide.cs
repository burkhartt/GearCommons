using System;
using System.Collections.Generic;
using System.Linq;

namespace GearCommons.API.Controllers {
	public class Guide {
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public IEnumerable<string> Tips { get; set; }
		public IEnumerable<string> Images { get; set; }
		public Rating Rating { get; set; }

		public void AddTip(string tip) {
			var tips = Tips.ToList();
			tips.Add(tip);
			Tips = tips;
		}

		public void AddImage(string image) {
			var images = Images.ToList();
			images.Add(image);
			Images = images;
		}

		public bool IsWithinMiles(int mileRadius, double latitude, double longitude) {
			var e = (3.1415926538*Latitude/180);
			var f = (3.1415926538*Longitude/180);
			var g = (3.1415926538*latitude/180);
			var h = (3.1415926538*longitude/180);
			var i = (Math.Cos(e)*Math.Cos(g)*Math.Cos(f)*Math.Cos(h) + Math.Cos(e)*Math.Sin(f)*Math.Cos(g)*Math.Sin(h) + Math.Sin(e)*Math.Sin(g));
			var j = (Math.Acos(i));
			var k = (6371*j);
			var miles = k*1.60934;
			return miles <= mileRadius;
		}

		public void VoteUp() {
			Rating.UpVotes++;
		}

		public void VoteDown() {
			Rating.DownVotes++;
		}
	}
}