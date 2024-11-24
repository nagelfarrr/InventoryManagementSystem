namespace InventoryManagementSystem.Models.Contracts
{
	public interface IIteam
	{
		int Id { get; }
		
		string ItemName { get; }

		string Description { get; }

		string GetDetails();
		double CalculateValue();
		string DisplayDescription();
	}
}
