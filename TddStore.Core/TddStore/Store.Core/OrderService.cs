using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddStore.Core.TddStore.Store.Core;

namespace TddStore.Core.TddStore
{
    public class OrderService
    {
        /*
        private IOrderDataService _orderDataService;
        private ICustomerService _customerService;

        public OrderService(IOrderDataService orderDataService, ICustomerService customerService)
        {
            _orderDataService = orderDataService;
            _customerService = customerService;
        }

        public object PlaceOrder(Guid customerId, ShoppingCart shoppingCart)
        {
            foreach (var item in shoppingCart.Items)
            {
                if (item.Quantity == 0)
                {
                    throw new InvalidOrderException();
                }
            }

            var customer = _customerService.GetCustomer(customerId);
            var order = new Order();
            return _orderDataService.Save(order);
            */
        }
    }
}
