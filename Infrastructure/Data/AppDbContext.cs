using Application.Commons.Contracts;
using Domain.orders;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class AppDbContext : IAppDbcontext
	{
		public List<Product> Products { get; }

		public List<OrderRequest> OrderRequests { get; }

		public Task SaveChanges()
		{
			throw new NotImplementedException();
		}
	}
}
