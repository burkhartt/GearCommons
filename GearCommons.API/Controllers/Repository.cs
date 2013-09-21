using System;
using System.Collections.Generic;

namespace GearCommons.API.Controllers {
	public class Repository<T> : IRepository<T> {
		private readonly IDatabaseFactory databaseFactory;

		public Repository(IDatabaseFactory databaseFactory) {
			this.databaseFactory = databaseFactory;
		}

		public IEnumerable<T> GetAll() {
			return databaseFactory.Get()[typeof (T).Name + "s"].All().ToList<T>();
		}

		public T GetById(Guid id) {
			return databaseFactory.Get()[GetDbTableName()].FindById(id);
		}

		private static string GetDbTableName() {
			return typeof (T).Name + "s";
		}

		public void Save(T @object) {
			databaseFactory.Get()[GetDbTableName()].Upsert(@object);
		}

		public void Delete(Guid id) {
			databaseFactory.Get()[GetDbTableName()].DeleteById(id);
		}
	}
}