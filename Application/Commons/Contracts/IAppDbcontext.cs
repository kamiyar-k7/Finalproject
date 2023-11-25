using Domain.orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Commons.Contracts;

public interface IAppDbcontext
{
	DbSet<Product> Products { get; }
	DbSet<OrderRequest> OrderRequests { get; }


	Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
