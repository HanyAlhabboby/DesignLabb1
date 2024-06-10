namespace DesignLabb1.Models
{

    //Observer designmönster 
    public interface IObserver
    {
        void Update(string stockSymbol, double stockPrice);
    }
}
