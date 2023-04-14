using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Persistence;
using StoreApp.Persistence.IDBContext;
using StoreApp.Persistence.Repositories;
using System.ComponentModel;
using System.Configuration;

namespace StoreApp
{
	public partial class MainForm : Form
	{
		private StoreAppDBContext? _dbContext;

		public static MainForm mainForm;
		public static AcceptedForm acceptedForm;
		public static OnStoreForm onStoreForm;
		public static SoldedForm soldedForm;
		public static CreationForm creationForm;
		public MainForm()
		{
			InitializeComponent();
			mainForm = this;
			acceptedForm = new AcceptedForm();
			onStoreForm = new OnStoreForm();
			soldedForm = new SoldedForm();
			creationForm = new CreationForm();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			_dbContext = new StoreAppDBContext();
			_dbContext.Database.EnsureCreated();

			StatusAll.Checked = true;
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			ReloadData(Status.All);
		}

		public void ReloadData(Status status)
		{
			dataGridView1.Rows.Clear();
			int sumCost = 0;
			var productRepo = new ProductRepo();
			List<Product> productsList; 
			List<string[]> data = new List<string[]>();
			switch (status)
			{
				case Status.All:
				productsList = productRepo.ReadAll();
					break;
				case Status.Accepted:
				productsList = productRepo.ReadAll().Where(p => p.StatusName == "Accepted").ToList();
					break;
				case Status.OnStore:
				productsList = productRepo.ReadAll().Where(p => p.StatusName == "OnStore").ToList();
					break;
				case Status.Solded:
				productsList = productRepo.ReadAll().Where(p => p.StatusName == "Sold").ToList();
					break;
				default:
					return;
			}

			for (int i = 0; i < productsList.Count; i++)
			{
				data.Add(new string[4]);

				data[i][0] = productsList[i].Id.ToString();
				data[i][1] = productsList[i].Name.ToString();
				data[i][2] = productsList[i].Cost.ToString();
				data[i][3] = productsList[i].StatusName.ToString();
				sumCost += productsList[i].Cost;
			}

			foreach (var item in data)
			{
				dataGridView1.Rows.Add(item);
			}

			SumCost.Text = sumCost.ToString();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);

			_dbContext?.Dispose();
			_dbContext = null;
		}

		private void Accepted_Click(object sender, EventArgs e)
		{
			acceptedForm.Show();
			this.Hide();
		}

		private void OnStore_Click(object sender, EventArgs e)
		{
			onStoreForm.Show();
			this.Hide();
		}

		private void Solded_Click(object sender, EventArgs e)
		{
			soldedForm.Show();
			this.Hide();
		}

		private void StatusAll_CheckedChanged(object sender, EventArgs e)
		{
			var radioButton = (RadioButton)sender;
			switch (radioButton.Text)
			{
				case "All":
					ReloadData(Status.All);
					break;
				case "Accepted":
					ReloadData(Status.Accepted);
					break;
				case "OnStore":
					ReloadData(Status.OnStore);
					break;
				case "Solded":
					ReloadData(Status.Solded);
					break;
			}
		}
	}

	public enum Status
	{
		All,
		Accepted,
		OnStore,
		Solded
	}
}