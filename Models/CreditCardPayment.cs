namespace DesignLabb1.Models
{
    public class CreditCardPayment : PaymentMethod 
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Håller på med CreditCard betalningen med: {amount: C}");
        }
    }
}
