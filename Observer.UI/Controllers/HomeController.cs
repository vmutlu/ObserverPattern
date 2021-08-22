using Microsoft.AspNetCore.Mvc;
using Observer.Business.Abstract;
using Observer.Business.Concrete;
using Observer.Entities.Concrete;
using Observer.Entities.Enums;

namespace Observer.UI.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IOrderService _orderService;
    private readonly SmsObserver _smsObserver;
    private readonly EmailObserver _emailObserver;

    public HomeController(ILogger<HomeController> logger, IOrderService orderService, SmsObserver smsObserver, EmailObserver emailObserver) => (_logger, _orderService,_smsObserver,_emailObserver) = (logger, orderService,smsObserver,emailObserver);

    public IActionResult Index()
    {
        var order = new Order()
        {
            OrderNumber = "11283A454B",
            OrderDate = DateTime.Now,
            TotalAmount = 100.00m,
            OrderStatus = OrderStatuses.PendingPayment
        };

        return View(order);
    }

    [HttpPost]
    public IActionResult Index(Order order)
    {
        Console.WriteLine("Gözlemciler Ekleniyor");

        _orderService.Attach(_smsObserver);
        _orderService.Attach(_emailObserver);

        Console.WriteLine("Sipariş durumu güncelleniyor...");

        _orderService.UpdateOrder(order);

        return View(order);
    }
}
