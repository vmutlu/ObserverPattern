using Observer.Entities.Concrete;

namespace Observer.Business.Abstract
{
    public interface IOrderObserver
    {
        void Update(Order order);
    }
}
