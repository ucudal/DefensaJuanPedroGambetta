namespace Ucu.Poo.Defense
{
    public interface IOfferItem
    {
        ResidueType ResidueType { get; set; }
        string Name { get; }
        int Price { get; }
        int Quantity { get; set; }
        public void AddItem(IOfferItem item, int quantity, int price);
    }
}