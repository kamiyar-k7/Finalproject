
#region Using

using Domain.orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Commands.CreateOrderRequest;

#endregion

public class CreateOrderRequestCommand : IRequest
{
	public OrderRequest OrderRequest { get; set; }
}

