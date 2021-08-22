using Observer.Business.Abstract;
using Observer.Business.Extensions;
using Observer.Entities.Concrete;

namespace Observer.Business.Concrete
{
    public class EmailObserver : IOrderObserver
    {
        // write email sending code
        public void Update(Order order) =>
            Console.WriteLine("Sipariş No'su '{0}' olan siparişinizin durumu: '{1}'. Müşteriye mail gönderildi.", order.OrderNumber, order.OrderStatus.GetDescription().ToString());
    }
}
