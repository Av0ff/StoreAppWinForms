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
	public partial class AcceptedForm : Form
	{
		public AcceptedForm()
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

			var acceptedRepo = new AcceptedRepo();
			List<string[]> data = new List<string[]>();
			var acceptedList = acceptedRepo.ReadAll();
			for (int i = 0; i < acceptedList.Count; i++)
			{
				data.Add(new string[4]);

				data[i][0] = acceptedList[i].Id.ToString();
				data[i][1] = acceptedList[i].Name.ToString();
				data[i][2] = acceptedList[i].Cost.ToString();
				data[i][3] = acceptedList[i].ProductId.ToString();
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

		private void Report_Click(object sender, EventArgs e)
		{
			MainForm.mainForm.Show();
			this.Hide();
		}

		private void OnStore_Click(object sender, EventArgs e)
		{
			MainForm.onStoreForm.Show();
			this.Hide();
		}

		private void AddProduct_Click(object sender, EventArgs e)
		{
			MainForm.creationForm.ShowDialog(this);
		}

		private void onStoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var id = dataGridView1.CurrentRow?.Cells[0].Value;
			if(id != null)
			{
				var idGuid = Guid.Parse(id.ToString());
				var acceptedRepo = new AcceptedRepo();
				acceptedRepo.EditStatus(idGuid, "OnStore");
				MainForm.acceptedForm.ReloadData();
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var id = dataGridView1.CurrentRow?.Cells[0].Value;
			if (id != null)
			{
				var idGuid = Guid.Parse(id.ToString());
				var acceptedRepo = new AcceptedRepo();
				acceptedRepo.Delete(idGuid);
				MainForm.acceptedForm.ReloadData();
			}
		}
	}
}
