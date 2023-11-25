using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Products.Queries.GetAllActiveProducts;

namespace EndPoint.Controllers;

public class ProductController : Controller
{
	private readonly IMediator _mediator;

	public ProductController(IMediator mediator) 
	{

		_mediator  = mediator;
	}


	public IActionResult Index()
	{
		GetAllActiveProductsQuery query = new GetAllActiveProductsQuery();
		var respnse = _mediator.Send(query);
		return View(respnse);
	}
}
