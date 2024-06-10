namespace DesignLabb1.Models
{
    public class PayPalPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Håller på med Paypalbetalningen med: {amount: C}");
        }
    }
}
