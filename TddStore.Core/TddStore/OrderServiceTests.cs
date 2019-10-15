using System;
using NUnit.Framework;
using TddStore.Core;
using TddStore.Core.TddStore;
using TddStore.Core.TddStore.Store.Core;
using TddStore.Core.TddStore.Store.Core.OrderException;
using Telerik.JustMock;

namespace ThirtyDaysOfTDD.UnitTests.TddStore
{
    [TestFixture]
    public class OrderServiceTests
    {

        [Test]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {

            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });

            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            var orderDataService = Mock.Create<IOrderDataService>();

            OrderService orderService = new OrderService(orderDataService);

            Mock.Arrange(() =>
            orderDataService.Save(Arg.IsAny<Order>())).Returns(expectedOrderId);

            var result = orderService.PlaceOrder(customerId, shoppingCart);

        }

        [Test]   
        public void WhenAUserAttemptsToOrderAnItemWithAQuantityOfZeroThrowInvalidOrderException()
        {


            // Arrange



            // Act



            // Assert

            Mock.Assert(orderDataService);

        }

    }
}
