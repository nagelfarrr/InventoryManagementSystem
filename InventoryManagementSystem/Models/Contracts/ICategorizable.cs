namespace InventoryManagementSystem.Models.Contracts
{
	public interface ICategorizable
	{
		string Category {  get; }

		string SetCategory();
		string GetCategory();
	}
}
