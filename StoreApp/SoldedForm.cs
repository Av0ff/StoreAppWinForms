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
	public partial class SoldedForm : Form
	{
		public SoldedForm()
		{
			InitializeComponent();
			dataGridView1.ContextMenuStrip = contextMenuStrip1;
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			ReloadData();
		}

		public void ReloadData()
		{
			dataGridView1.Rows.Clear();

			var SoldedsRepo = new SoldedsRepo();
			List<string[]> data = new List<string[]>();
			var soldedsList = SoldedsRepo.ReadAll();
			for (int i = 0; i < soldedsList.Count; i++)
			{
				data.Add(new string[4]);

				data[i][0] = soldedsList[i].Id.ToString();
				data[i][1] = soldedsList[i].Name.ToString();
				data[i][2] = soldedsList[i].Cost.ToString();
				data[i][3] = soldedsList[i].ProductId.ToString();
			}
			foreach (var item in data)
			{
				dataGridView1.Rows.Add(item);
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			Application.Exit();
		}

		private void OnStore_Click(object sender, EventArgs e)
		{
			MainForm.onStoreForm.Show();
			this.Hide();
		}

		private void Accepted_Click(object sender, EventArgs e)
		{
			MainForm.acceptedForm.Show();
			this.Hide();
		}

		private void Report_Click(object sender, EventArgs e)
		{
			MainForm.mainForm.Show();
			this.Hide();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var id = dataGridView1.CurrentRow?.Cells[0].Value;
			if (id != null)
			{
				var idGuid = Guid.Parse(id.ToString());
				var soldedsRepo = new SoldedsRepo();
				soldedsRepo.Delete(idGuid);
				MainForm.soldedForm.ReloadData();
			}
		}
	}
}
