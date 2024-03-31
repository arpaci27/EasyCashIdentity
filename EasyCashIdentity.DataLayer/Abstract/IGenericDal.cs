using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.DataAccesLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T t);
		T Delete(T t);
		void Update(T t);
		T GetByID(int id);
		List<T> GetList();
	}
}
