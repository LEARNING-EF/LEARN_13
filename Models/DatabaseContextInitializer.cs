namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
		}
	}
}
