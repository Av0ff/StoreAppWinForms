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
	public partial class OnStoreForm : Form
	{
		public OnStoreForm()
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

			var onStoreRepo = new OnStoreRepo();
			List<string[]> data = new List<string[]>();
			var onStoreList = onStoreRepo.ReadAll();
			for (int i = 0; i < onStoreList.Count; i++)
			{
				data.Add(new string[4]);

				data[i][0] = onStoreList[i].Id.ToString();
				data[i][1] = onStoreList[i].Name.ToString();
				data[i][2] = onStoreList[i].Cost.ToString();
				data[i][3] = onStoreList[i].ProductId.ToString();
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

		private void Solded_Click(object sender, EventArgs e)
		{
			MainForm.soldedForm.Show();
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

		private void soldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var id = dataGridView1.CurrentRow?.Cells[0].Value;
			if (id != null)
			{
				var idGuid = Guid.Parse(id.ToString());
				var onStoreRepo = new OnStoreRepo();
				onStoreRepo.EditStatus(idGuid, "Sold");
				MainForm.onStoreForm.ReloadData();
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var id = dataGridView1.CurrentRow?.Cells[0].Value;
			if (id != null)
			{
				var idGuid = Guid.Parse(id.ToString());
				var onStoreRepo = new OnStoreRepo();
				onStoreRepo.Delete(idGuid);
				MainForm.onStoreForm.ReloadData();
			}
		}
	}
}
