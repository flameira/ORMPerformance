namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	#region Usings

	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using NPoco;

	#endregion

	[TableName("CheckListHeader")]
	[PrimaryKey("Id")]
	[Table("CheckListHeader")]
	public class CheckListHeader : Base
	{
		public string Description { get; set; }
		public bool IsObsolete { get; set; }
		public bool IsSystem { get; set; }

		[Reference(ReferenceType.OneToOne, ColumnName = "CheckTypeId", ReferenceMemberName = "Id")]
		public virtual CheckTypes CheckType { get; set; }

		[NPoco.Column("CheckTypeId")]
		[Display(Name = "Check list type")]
		public int CheckTypeId { get; set; }

		[Display(Name = "Vehicle type")]
		[NPoco.Column("VehicleTypeId")]
		public int VehicleTypeId { get; set; }

		[Reference(ReferenceType.OneToOne, ColumnName = "VehicleTypeId", ReferenceMemberName = "Id")]
		public  virtual VehicleType VehicleType { get; set; }

	
	}


	public class CheckListHeaderADODB : Base
	{
		public string Description { get; set; }
		public bool IsObsolete { get; set; }
		public bool IsSystem { get; set; }
		public int CT_Id { get; set; }

		public DateTime CT_CreatedDateTime { get; set; }

		public DateTime CT_UpdatedDateTime { get; set; }

		public string CT_Name { get; set; }

		public bool CT_IsSystem { get; set; }
		
		public int VehicleTypeId { get; set; }

	}
}