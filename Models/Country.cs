namespace Models
{
	public class Country : BaseEntity
	{
		#region Configuration
		/// <summary>
		/// Fluent Api
		/// </summary>
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
		{
			public Configuration() : base()
			{
				// Note: Attribute is better!
				ToTable(tableName: "Countries");

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

				Property(current => current.Name)
					// Note: Attribute is better!
					.HasColumnName("Name")
					// Note: Attribute is better!
					.HasColumnOrder(1)
					// Note: Attribute is better!
					.IsRequired()
					// Note: Fluent Api is better!
					.IsUnicode(true)
					// Note: Fluent Api is better!
					.HasMaxLength(50)
					// Note: Fluent Api is better!
					.IsVariableLength()
					;

				// Char(x):
				//	.IsUnicode(false)
				//	.HasMaxLength(x)
				//	.IsFixedLength()

				// nChar(x):
				//	.IsUnicode(true)
				//	.HasMaxLength(x)
				//	.IsFixedLength()

				// VarChar(x):
				//	.IsUnicode(false)
				//	.HasMaxLength(x)
				//	.IsVariableLength()

				// nVarChar(x):
				//	.IsUnicode(true)
				//	.HasMaxLength(x)
				//	.IsVariableLength()

				// VarChar(Max):
				//	.IsUnicode(false)
				//	.IsMaxLength()
				//	.IsVariableLength()

				// nVarChar(Max):
				//	.IsUnicode(true)
				//	.IsMaxLength()
				//	.IsVariableLength()

				// توصيه من
				// استفاده نماييد Fluent Api فقط برای حالات ذيل از

				// Char(x):
				//	.IsUnicode(false)
				//	.HasMaxLength(x)
				//	.IsFixedLength()

				// nChar(x):
				//	.IsUnicode(true)
				//	.HasMaxLength(x)
				//	.IsFixedLength()

				// VarChar(x):
				//	.IsUnicode(false)
				//	.HasMaxLength(x)
				//	.IsVariableLength()

				// VarChar(Max):
				//	.IsUnicode(false)
				//	.IsMaxLength()
				//	.IsVariableLength()
			}
		}
		#endregion /Configuration

		public Country() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********

		// **********
		// با نگاه شیء گرايی
		public virtual System.Collections.Generic.IList<State> States { get; set; }
		// **********
	}
}
