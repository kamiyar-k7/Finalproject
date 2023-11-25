using Microsoft.AspNetCore.Mvc;


namespace EndPoint.Controllers;

public class ProductController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
