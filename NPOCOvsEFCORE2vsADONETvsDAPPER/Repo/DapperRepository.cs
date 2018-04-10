namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Repo
{
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using System.Linq;
	using Dapper;
	using Models;

	public class DapperRepository
	{
		private string _conetionString;

		public DapperRepository(string conetionString)
		{
			_conetionString = conetionString;
		}

		public List<CheckListHeaderADODB> GetAllCheklistByCheckType(int checkTypeId)
		{
			using (IDbConnection db = new SqlConnection(_conetionString))
			{
				return db.Query<CheckListHeaderADODB>(
						$"SELECT Top 1000 CLH.Id, CLH.Description, CLH.CreatedDateTime, CLH.UpdatedDateTime, CLH.IsObsolete, CLH.ObsoletedDateTime, CLH.CheckTypeId, CLH.IsSystem, CLH.VehicleTypeId, CT.Id AS CT_Id, " +
						$"CT.CreatedDateTime AS CT_CreatedDateTime, CT.UpdatedDateTime AS CT_UpdatedDateTime, CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem from CheckListHeader CLH left join CheckType CT on CLH.CheckTypeId=Ct.Id " +
						$" where CheckTypeId={checkTypeId} order by VehicleTypeId asc")
					.ToList();
			}
		}
	}
}