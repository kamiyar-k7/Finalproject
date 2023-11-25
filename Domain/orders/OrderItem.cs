using Domain.Products;

namespace Domain.orders
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int OrderRequestId { get; set; }
		public int ProductId { get; set; }

		public Product product { get; set; }
		public OrderRequest OrderRequest { get; set; }
	}

}
