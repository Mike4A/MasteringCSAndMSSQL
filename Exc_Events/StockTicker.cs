using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_Events
{
    public class StockTicker
    {
        public event EventHandler<decimal>? PriceChanged;

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPriceChanged(_price);
                }
            }
        }

        protected virtual void OnPriceChanged(decimal newPrice)
        {
            PriceChanged?.Invoke(this, newPrice);
        }
    }
}
