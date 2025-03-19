using Exc_Events;

StockTicker ticker = new StockTicker();
ticker.PriceChanged += (sender, price) => Console.WriteLine($"New price: {price}");
ticker.Price = 100.50m;