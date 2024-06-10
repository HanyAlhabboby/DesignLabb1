using DesignLabb1.Models;

namespace DesignLabb1.Factories
{
    public class CreditCardPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new CreditCardPayment();
        }
    }
}
