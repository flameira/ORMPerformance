namespace NPOCOvsEFCORE2vsADONETvsDAPPER
{
	#region Usings

	using System.Collections.Generic;
	using System.Data;
	using BenchmarkDotNet.Attributes;
	using Models;
	using Repo;

	#endregion

	/// <summary>
	/// </summary>
	public class NpocOvsEFvsAdonetvsDapper
	{
		private readonly AdodbRepository _adodbRepo;
		private readonly DapperRepository _dapperRepo;
		private readonly EFRepository _efRepo;
		private readonly NpocoRepository _npocoRepo;

		private readonly string conetionString =
			$"Server=LAPTOP\\SQLEXPRESS;Database=ORMPerformance;persist security info=True;Integrated Security=SSPI";

		/// <summary>
		/// </summary>
		public NpocOvsEFvsAdonetvsDapper()
		{
			_efRepo = new EFRepository(conetionString);
			_npocoRepo = new NpocoRepository(conetionString);
			_adodbRepo = new AdodbRepository(conetionString);
			_dapperRepo = new DapperRepository(conetionString);
		}

		[Benchmark]
		public DataTable GetCheckListHeadersWithAdodb()
		{
			return _adodbRepo.GetAllCheklistByCheckType(1);
		}

		[Benchmark]
		public List<CheckListHeaderADODB> GetCheckListHeadersWithDapper()
		{
			return _dapperRepo.GetAllCheklistByCheckType(1);
		}

		[Benchmark]
		public List<CheckListHeader> GetCheckListHeadersWithEFram()
		{
			return _efRepo.GetAllCheklistByCheckType(1);
		}

		[Benchmark]
		public List<CheckListHeader> GetCheckListHeadersWithNpoco()
		{
			return _npocoRepo.GetAllCheklistByCheckType(1);
		}
	}
}