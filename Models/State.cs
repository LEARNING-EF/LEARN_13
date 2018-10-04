namespace Models
{
	public class State : BaseEntity
	{
		#region Configuration
		/// <summary>
		/// Fluent Api
		/// </summary>
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<State>
		{
			public Configuration() : base()
			{
				// Note: Attribute is better!
				ToTable(tableName: "States");

				// Note: Attribute is better!
				HasKey(current => current.Id);

				// Note: Attribute is better!
				Property(current => current.Id)
					.HasDatabaseGeneratedOption
					(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

				Property(current => current.Id)
					// Note: Attribute is better!
					.HasColumnName("Id")
					// Note: Attribute is better!
					.HasColumnOrder(0)
					// Note: Attribute is better!
					.IsRequired()
					;

				Property(current => current.CountryId)
					// Note: Attribute is better!
					.HasColumnName("CountryId")
					// Note: Attribute is better!
					.HasColumnOrder(1)
					// Note: Attribute is better!
					.IsRequired()
					;

				Property(current => current.Name)
					// Note: Attribute is better!
					.HasColumnName("Name")
					// Note: Attribute is better!
					.HasColumnOrder(2)
					// Note: Attribute is better!
					.IsRequired()
					// Note: Fluent Api is better!
					.IsUnicode(true)
					// Note: Fluent Api is better!
					.HasMaxLength(50)
					// Note: Fluent Api is better!
					.IsVariableLength()
					;

				// Note: Fluent Api is better!
				HasRequired(current => current.Country)
					.WithMany(country => country.States)
					.HasForeignKey(current => current.CountryId)
					.WillCascadeOnDelete(false);

				//خودش
				//HasRequired(current => current.Country)
				//طرف مقابل
				//.WithMany(country => country.States)
				//خودش
				//.HasForeignKey(current => current.CountryId)
				//.WillCascadeOnDelete(false)
				//;

				//HasOptional(current => current.Country)
				//	.WithMany(country => country.States)
				//	.HasForeignKey(current => current.CountryId)
				//	.WillCascadeOnDelete(false)
				//	;
			}
		}
		#endregion /Configuration

		public State() : base()
		{
		}

		// **********
		// **********
		// **********
		// صرفا با نگاه طراحی بانک اطلاعاتی
		public System.Guid CountryId { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual Country Country { get; set; }
		// **********
		// **********
		// **********

		// **********
		public string Name { get; set; }
		// **********
	}
}
