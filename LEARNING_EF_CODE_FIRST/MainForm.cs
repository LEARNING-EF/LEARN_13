using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected System.Guid CountryId
		{
			get
			{
				return new System.Guid("2fc2231e-386f-4b5c-b6fd-107e77c129b0");
			}
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void CreateANewCountryButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Country country = new Models.Country();

				country.Name = "Iran";

				databaseContext.Countries.Add(country);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void CreateCountryStatesButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Country country =
					databaseContext.Countries
					.FirstOrDefault();

				// Solution (1)
				Models.State state1 = new Models.State();

				state1.Name = "State (1)";
				state1.CountryId = country.Id;

				databaseContext.States.Add(state1);
				// /Solution (1)

				// Solution (2)
				Models.State state2 = new Models.State();

				state2.Name = "State (2)";
				state2.Country = country;

				databaseContext.States.Add(state2);
				// /Solution (2)

				// Solution (3)
				Models.State state3 = new Models.State();

				state3.Name = "State (3)";

				country.States.Add(state3);
				// /Solution (3)

				databaseContext.SaveChanges();

				System.Guid id1 = state1.CountryId;
				System.Guid id2 = state2.CountryId;
				System.Guid id3 = state3.CountryId;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
