using DesignLabb1.Models;

namespace DesignLabb1.Display
{
    public class StockDisplay : IObserver
    {
        private string stockSymbol;
        private double stockPrice;
        public void Update(string stockSymbol, double stockPrice)
        {
            this.stockSymbol = stockSymbol;
            this.stockPrice = stockPrice;
            Display();
        }
        public void Display() 
        {
            Console.WriteLine($"Stock: {stockSymbol}, Price: {stockPrice}");
        }
    }
}
