using Application.Commons.Contracts;
using Domain.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Queries.GetAllActiveProducts
{
	public class GetAllActiveProductsQueryHandler : IRequestHandler<GetAllActiveProductsQuery, List<Product>>
	{
		private readonly IAppDbcontext _dbcontext;

		public GetAllActiveProductsQueryHandler(IAppDbcontext appDbcontext) 
		{
			_dbcontext =  appDbcontext;
		}
		public async Task<List<Product>> Handle(GetAllActiveProductsQuery request, CancellationToken cancellationToken)
		{
			var data = await _dbcontext.Products
				.Where(e => e.Status == ProductStatus.Active)
				.Skip(request.PageNumber * request.PageSize.Value)
				.Take(request.PageSize.Value)
				.ToListAsync();
			return data;
		}
	}


}
