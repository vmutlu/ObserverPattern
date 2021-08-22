using Observer.Entities.Concrete;

namespace Observer.Business.Abstract
{
    public interface IOrderService : IOrderNotifier
    {
        void UpdateOrder(Order order);
    }
}
