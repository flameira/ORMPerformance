namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Base
	{
		[Key]
		public int Id { get; set; }
		public DateTime CreatedDateTime { get; set; } =DateTime.Now;
		public DateTime UpdatedDateTime { get; set; } =DateTime.Now;
	
	}

}
