using System;
using System.Collections.Generic;

namespace GearCommons.API.Controllers {
	public interface IRepository<T> {
		IEnumerable<T> GetAll();
		T GetById(Guid id);
		void Save(T @object);
		void Delete(Guid id);
	}
}