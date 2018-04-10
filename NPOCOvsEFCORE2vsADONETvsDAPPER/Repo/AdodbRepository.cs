namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Repo
{
	#region Usings

	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using System.Reflection;
	using Models;

	#endregion

	public class AdodbRepository
	{
		private string _conetionString;

		public AdodbRepository(string conetionString)
		{
			_conetionString = conetionString;
		}

		public DataTable GetAllCheklistByCheckType(int checkTypeId)
		{
			using (SqlConnection conn = new SqlConnection(_conetionString))
			{
				conn.Open();
				using (SqlDataAdapter adapter = new
					SqlDataAdapter(
						"SELECT Top 1000 CLH.Id, CLH.Description, CLH.CreatedDateTime, CLH.UpdatedDateTime, CLH.IsObsolete, CLH.ObsoletedDateTime, CLH.CheckTypeId, CLH.IsSystem, CLH.VehicleTypeId, CT.Id AS CT_Id, " +
						"CT.CreatedDateTime AS CT_CreatedDateTime, CT.UpdatedDateTime AS CT_UpdatedDateTime, CT.Name AS CT_Name, CT.IsSystem AS CT_IsSystem from CheckListHeader CLH left join CheckType CT on CLH.CheckTypeId=Ct.Id " +
						" where CheckTypeId=@ID order by VehicleTypeId asc",
						conn))
				{
					adapter.SelectCommand.Parameters.Add(new SqlParameter("@ID", checkTypeId));
					DataTable tableHeader = new DataTable();
					adapter.Fill(tableHeader);
					return tableHeader;
					//return ConvertDataTable<CheckListHeaderADODB>(tableHeader);
				}
			}
		}

		private static List<T> ConvertDataTable<T>(DataTable dt)
		{
			List<T> data = new List<T>();
			foreach (DataRow row in dt.Rows)
			{
				T item = GetItem<T>(row);
				data.Add(item);
			}

			return data;
		}

		private static T GetItem<T>(DataRow dr)
		{
			Type temp = typeof(T);
			T obj = Activator.CreateInstance<T>();

			foreach (DataColumn column in dr.Table.Columns)
			foreach (PropertyInfo pro in temp.GetProperties())
				if (pro.Name == column.ColumnName)
					pro.SetValue(obj, dr[column.ColumnName], null);
				else
					continue;
			return obj;
		}
	}
}