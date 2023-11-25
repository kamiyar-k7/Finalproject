using Domain.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetAllActiveProducts
{
	public class GetAllActiveProductsQuery : IRequest<List< Product>>
	{

		public int PageNumber { get; set; }
		public int? PageSize { get; set; } = 20;


	}


}
