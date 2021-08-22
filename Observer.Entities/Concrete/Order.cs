using Observer.Entities.Enums;

namespace Observer.Entities.Concrete
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public OrderStatuses OrderStatus { get; set; }
    }
}
