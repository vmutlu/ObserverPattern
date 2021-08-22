using Observer.Entities.Concrete;

namespace Observer.Business.Abstract
{
    public interface IOrderNotifier
    {
        void Attach(IOrderObserver observer);

        void Detach(IOrderObserver observer);

        void Notify(Order order);
    }
}
