using Domain.Products;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Products.Queries.GetAllActiveProducts;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
	private readonly IMediator _mediator;

	public ProductController(IMediator mediator) 
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async Task< List<Product>> GetProducts(int pagenumber ) 
	{
		GetAllActiveProductsQuery query = new GetAllActiveProductsQuery() { PageNumber = pagenumber };
		var response = await _mediator.Send(query);

		return response;
	}

	
}
