using Application.Commons.Contracts;
using Domain.orders;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
	public class AppDbContext : DbContext, IAppDbcontext
	{
		
		public DbSet<Product> Products { get; }

		public DbSet<OrderRequest> OrderRequests { get; } 


		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
