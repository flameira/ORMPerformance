namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Repo
{
	#region Usings

	using System.Collections.Generic;
	using System.Data.SqlClient;
	using Models;
	using NPoco;

	#endregion

	public class NpocoRepository
	{
		private string _conetionString;

		public NpocoRepository(string conetionString)
		{
			_conetionString = conetionString;
		}

		public List<CheckListHeader> GetAllCheklistByCheckType(int CheckTypeId)
		{
			using (IDatabase db = new Database(_conetionString,DatabaseType.SqlServer2012,SqlClientFactory.Instance))
			{
				var cChecLists = db.Query<CheckListHeader>()
				                   .Include(m => m.CheckType)
				                   .Where(m => m.CheckTypeId == CheckTypeId)
				                   .OrderBy(m => m.VehicleTypeId)
				                   .Limit(1000);

				return cChecLists.ToList();
			}
		}
	}
}