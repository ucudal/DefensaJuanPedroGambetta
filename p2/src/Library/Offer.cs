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

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }
        //implementar un metodo publico que retorne un string con el detalle de la oferta
        public string AsText()
        {
            StringBuilder stringoferta = new StringBuilder();
            stringoferta.AppendLine($"Oferta válida hasta {this.EndDate.ToShortDateString()}");
            stringoferta.AppendLine("Items:");
            foreach (OfferItem item in this.items)
            {
                stringoferta.AppendLine(item.AsText());
            }
            return stringoferta.ToString();
        }
    }
}