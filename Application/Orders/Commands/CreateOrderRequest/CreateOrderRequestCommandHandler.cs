
#region Using

using Application.Commons.Contracts;
using Domain.orders;
using MediatR;

namespace Application.Orders.Commands.CreateOrderRequest;

#endregion

public class CreateOrderRequestCommandHandler : IRequestHandler<CreateOrderRequestCommand>
{
	private readonly IAppDbcontext _dbcontext;

	public CreateOrderRequestCommandHandler(IAppDbcontext AppDbContext)
	{
		_dbcontext = AppDbContext;
	}

	public async Task Handle(CreateOrderRequestCommand request, CancellationToken cancellationToken)
	{

		OrderRequest orderRequest = request.OrderRequest;

		orderRequest.OrderDate = DateTime.UtcNow;
		orderRequest.orderStatus = OrderStatus.Registered;

		_dbcontext.OrderRequests.Add(orderRequest);
		await _dbcontext.SaveChangesAsync();


		
	}
}

