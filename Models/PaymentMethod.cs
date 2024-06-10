namespace DesignLabb1.Models
{
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);
        
    }
}
