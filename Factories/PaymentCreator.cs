using DesignLabb1.Models;

namespace DesignLabb1.Factories
{

    //Här tillämpar jag abstrakt klass som är relaterad till Factory designmönster
    public  abstract class PaymentCreator
    {

        public abstract PaymentMethod CreatePaymentMethod();
        public void ProcessPayment (decimal amount)
        {
            PaymentMethod paymentMethod = CreatePaymentMethod();
            paymentMethod.ProcessPayment(amount);
        }
    }
}
