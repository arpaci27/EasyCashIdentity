using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
	public class CustomerAccountProcessManager : ICustomerAccountProcessService

	{
		private readonly ICustomerAccountProcessService _customerAccountProcessService;

		public CustomerAccountProcessManager(ICustomerAccountProcessService customerAccountProcessService)
		{
			_customerAccountProcessService = customerAccountProcessService;
		}

		public void TDelete(CustomerAccountProcess t)
		{
			_customerAccountProcessService.TDelete(t);
		}

		public CustomerAccountProcess TGetByID(int id)
		{
			return _customerAccountProcessService.TGetByID(id);
		}

		public List<CustomerAccountProcess> TGetList()
		{
			return _customerAccountProcessService.TGetList();
		}

		public void TInsert(CustomerAccountProcess t)
		{
			_customerAccountProcessService.TInsert(t);
		}

		public void TUpdate(CustomerAccountProcess t)
		{
			_customerAccountProcessService.TUpdate(t);
		}
	}
}
