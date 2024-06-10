using DesignLabb1.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DesignLabb1.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(string paymentType, decimal amount)
        {
            PaymentCreator creator;

            if(paymentType=="CreditCard")
            {
                creator = new CreditCardPaymentCreator();
            }
            else if (paymentType=="PayPal")
            {
                
                    creator = new PayPalPaymentCreator();
                
            }
            else
            {
                return BadRequest("Invalid payment type");
            }
            creator.ProcessPayment(amount);
            return View ("Success");
        }
    }
}
