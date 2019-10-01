using System;
using TddStore.Core.TddStore;

namespace TddStore.Core
{
    public interface IOrderDataService
    {
        Guid Save(Order order);
    }
}