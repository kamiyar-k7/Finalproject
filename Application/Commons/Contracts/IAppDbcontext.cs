using Domain.orders;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.Contracts
{
	public interface IAppDbcontext
	{
		List<Product> Products { get; }
		List<OrderRequest> OrderRequests { get; }
		Task SaveChanges();
	}
}
