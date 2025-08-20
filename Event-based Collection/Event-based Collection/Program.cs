var stock = new Stock { Symbol = 'B' };
stock.OnPriceChanged += (s) => Console.WriteLine($"Stock {s.Symbol} price changed to {s.Price}");
stock.pricechanged(100.50m);
public class Stock {
    public event Action<Stock> OnPriceChanged;
    public decimal Price { get; set; }
   public  char Symbol { get; set; }

    public void pricechanged(decimal price)
    {
        this.Price= price;
        OnPriceChanged?.Invoke(this);
    }
}
