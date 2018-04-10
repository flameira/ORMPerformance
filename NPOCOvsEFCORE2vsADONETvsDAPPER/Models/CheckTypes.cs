namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using NPoco;

	#region Usings

	#endregion

	[TableName("CheckType")]
	[PrimaryKey("Id")]
	[Table("CheckType")]
	public class CheckTypes : Base
	{
		public string Name { get; set; }
		public bool IsSystem { get; set; }
	}
}