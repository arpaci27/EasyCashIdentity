using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.EntityLayer.Concrete
{
	public class CustomerAccountProcess
	{
        public int CustomerAccountProcessID { get; set; }
        public int ProcessType { get; set; }

        public int Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public CustomerAccount SenderCustomer { get; set; }
        public CustomerAccount ReceiverCustomer { get; set; }
    }
}
