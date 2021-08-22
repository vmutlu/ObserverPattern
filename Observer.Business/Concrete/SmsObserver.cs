using Observer.Business.Abstract;
using Observer.Business.Extensions;
using Observer.Entities.Concrete;

namespace Observer.Business.Concrete
{
    public class SmsObserver : IOrderObserver
    {
        // write sms sending code
        public void Update(Order order) =>
            Console.WriteLine("Sipariş No'su '{0}' olan siparişinizin durumu: '{1}'. Müşteriye Sms gönderildi.", order.OrderNumber, order.OrderStatus.GetDescription().ToString());
    }
}
