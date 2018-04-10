namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Repo
{
	#region Usings

	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.EntityFrameworkCore;
	using Models;

	#endregion

	public class EFRepository
	{
		private string _conetionString;

		public EFRepository(string conetionString)
		{
			_conetionString = conetionString;
		}

		public List<CheckListHeader> GetAllCheklistByCheckType(int CheckTypeId)
		{
			using (var db = new ApplicationDbContext(_conetionString))
			{
				var cheklists = db.CheckListHeader
				                  .Where(b => b.CheckTypeId == CheckTypeId)
				                  .OrderBy(b => b.VehicleTypeId)
				                  .Include(p => p.CheckType).Take(1000);
				
				return cheklists.ToList();
			}
		}
	}
}