namespace NPOCOvsEFCORE2vsADONETvsDAPPER.Models
{
	using Microsoft.EntityFrameworkCore;

	#region Usings

	#endregion

	public class ApplicationDbContext : DbContext
	{
		public DbSet<CheckListHeader> CheckListHeader { get; set; }
		public DbSet<CheckTypes> CheckTypes { get; set; }
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{ }

		public ApplicationDbContext(string connectionString) : base(GetOptions(connectionString))
		{ }
		private static DbContextOptions GetOptions(string connectionString)
		{
			return new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;
		}
	}
}