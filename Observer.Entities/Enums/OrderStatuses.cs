using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Observer.Entities.Enums
{
    public enum OrderStatuses
    {
        [Description("Ödeme Bekleniyor")]
        PendingPayment = 1,
        [Description("Sipariş Beklemede")]
        OnHold = 2,
        [Description("Sipariş İşlemde")]
        Processing = 3,
        [Description("Sipariş Kapatıldı")]
        Cancelled = 4,
        [Description("Sipariş Geri İade")]
        Refunded = 5,
        [Description("Sipariş Tamamlandı")]
        Completed = 6
    }
}
