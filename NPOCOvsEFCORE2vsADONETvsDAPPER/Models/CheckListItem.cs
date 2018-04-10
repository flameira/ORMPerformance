namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using NPoco;

	#region Usings

	#endregion

	[TableName("CheckListItem")]
	[PrimaryKey("Id")]
	[Table("CheckListItem")]
	public class CheckListItem : Base
	{
		[Reference(ReferenceType.OneToOne, ColumnName = "CheckListHeaderId", ReferenceMemberName = "Id")]
		public virtual CheckListHeader CheckListHeader { get; set; }

		[NPoco.Column("CheckListHeaderId")]
		public int CheckListHeaderID { get; set; }


		[NPoco.Column("ItemId")]
		public int ItemId { get; set; }

		public int Order { get; set; }
	}

	
}