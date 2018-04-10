namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	using NPoco;

	#region Usings

	#endregion

	[TableName("VehicleType")]
	[PrimaryKey("Id")]
	public class VehicleType : Base
	{
		public string Name { get; set; }
	}
}