using StoreApp.Data;
using StoreApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
	public partial class CreationForm : Form
	{
		public CreationForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			var statusRepo = new StatusRepo();
			var items = statusRepo.ReadAll();
			foreach (var item in items)
			{
				dropStatus.Items.Add(item);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			var product = new ProductViewModel()
			{
				Name = textName.Text,
				Cost = int.Parse(textCost.Text),
				Status = dropStatus.SelectedItem.ToString()
			};
			switch (product.Status)
			{
				case "Accepted":
					var acceptedRepo = new AcceptedRepo();
					acceptedRepo.Create(product);
					MainForm.acceptedForm.ReloadData();
					break;
				case "OnStore":
					var onStore = new OnStoreRepo();
					onStore.Create(product);
					MainForm.onStoreForm.ReloadData();
					break;
				case "Sold":
					var solded = new SoldedsRepo();
					solded.Create(product);
					MainForm.soldedForm.ReloadData();
					break;
			}
		}
	}
}
