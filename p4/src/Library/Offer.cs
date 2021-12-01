using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (OfferItem item in this.items)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public OfferItem AddItem(IOfferItem item, int quantity, int price)
        {
            OfferItem offerItem = new OfferItem(item, quantity, price);
            this.items.Add(offerItem);
            return offerItem;
        }
        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }
    }
}