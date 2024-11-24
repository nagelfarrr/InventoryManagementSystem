namespace InventoryManagementSystem.Models.Contracts
{
	public interface ISellable
	{
		double Price { get; }

		double SetPrice();
		double GetPrice();
	}
}
