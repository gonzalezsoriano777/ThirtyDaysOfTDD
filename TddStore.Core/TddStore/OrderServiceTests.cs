using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TddStore.Core;
using TddStore.Core.TddStore.Store.Core;

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

        }

    }
}
