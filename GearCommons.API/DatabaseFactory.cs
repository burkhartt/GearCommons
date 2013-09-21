using Simple.Data;
using Simple.Data.MongoDB;

namespace GearCommons.API {
	public class DatabaseFactory : IDatabaseFactory {
		private readonly string connectionString;

		public DatabaseFactory(string connectionString) {
			this.connectionString = connectionString;
		}

		public dynamic Get() {
			return Database.Opener.OpenMongo(connectionString);
		}
	}
}