namespace Warehouse;

class Stock
{
	public Item Item { get; set; }
	public int Quality { get; set; }

	//constructor
	public Stock (Item item, int quality)
	{
		Item = item;
		Quality = quality;
	}
}