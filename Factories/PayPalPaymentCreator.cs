using DesignLabb1.Models;

namespace DesignLabb1.Factories
{
    public class PayPalPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new PayPalPayment();
        }
    }
}
