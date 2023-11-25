using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.orders
{
	public class OrderRequest
	{
		public int Id { get; set; }	
		public int customerId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DeliveryItem { get; set; }

		public OrderStatus orderStatus { get; set; }
	}

}
