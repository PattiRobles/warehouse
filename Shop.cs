namespace Warehouse;

class Shop {

	public string Name { get; set; }
	public List<Stock> StockList {get; set: }	

	//constructor
	public Shop (string name) {

		Name = name;
		StockList = new List<Stock>();
	}

	//method
	public void AddToShop(Item item, int quantity)
	{
		Stock stockItem = new Stock(item, quantity);
		StockList.Add(stockItem);
	}
}