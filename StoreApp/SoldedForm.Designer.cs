namespace StoreApp
{
	partial class SoldedForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.OnStore = new System.Windows.Forms.Button();
			this.Accepted = new System.Windows.Forms.Button();
			this.Report = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Grid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OnStore
			// 
			this.OnStore.Location = new System.Drawing.Point(108, 409);
			this.OnStore.Name = "OnStore";
			this.OnStore.Size = new System.Drawing.Size(94, 29);
			this.OnStore.TabIndex = 14;
			this.OnStore.Text = "On Store";
			this.OnStore.UseVisualStyleBackColor = true;
			this.OnStore.Click += new System.EventHandler(this.OnStore_Click);
			// 
			// Accepted
			// 
			this.Accepted.Location = new System.Drawing.Point(8, 409);
			this.Accepted.Name = "Accepted";
			this.Accepted.Size = new System.Drawing.Size(94, 29);
			this.Accepted.TabIndex = 13;
			this.Accepted.Text = "Accepted";
			this.Accepted.UseVisualStyleBackColor = true;
			this.Accepted.Click += new System.EventHandler(this.Accepted_Click);
			// 
			// Report
			// 
			this.Report.Location = new System.Drawing.Point(208, 409);
			this.Report.Name = "Report";
			this.Report.Size = new System.Drawing.Size(94, 29);
			this.Report.TabIndex = 12;
			this.Report.Text = "Report";
			this.Report.UseVisualStyleBackColor = true;
			this.Report.Click += new System.EventHandler(this.Report_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Id,
            this.Grid_Name,
            this.Grid_Cost,
            this.Grid_ProductId});
			this.dataGridView1.Location = new System.Drawing.Point(17, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(555, 348);
			this.dataGridView1.TabIndex = 15;
			// 
			// Grid_Id
			// 
			this.Grid_Id.HeaderText = "Id";
			this.Grid_Id.MinimumWidth = 6;
			this.Grid_Id.Name = "Grid_Id";
			this.Grid_Id.ReadOnly = true;
			this.Grid_Id.Width = 125;
			// 
			// Grid_Name
			// 
			this.Grid_Name.HeaderText = "Name";
			this.Grid_Name.MinimumWidth = 6;
			this.Grid_Name.Name = "Grid_Name";
			this.Grid_Name.ReadOnly = true;
			this.Grid_Name.Width = 125;
			// 
			// Grid_Cost
			// 
			this.Grid_Cost.HeaderText = "Cost";
			this.Grid_Cost.MinimumWidth = 6;
			this.Grid_Cost.Name = "Grid_Cost";
			this.Grid_Cost.ReadOnly = true;
			this.Grid_Cost.Width = 125;
			// 
			// Grid_ProductId
			// 
			this.Grid_ProductId.HeaderText = "ProductId";
			this.Grid_ProductId.MinimumWidth = 6;
			this.Grid_ProductId.Name = "Grid_ProductId";
			this.Grid_ProductId.ReadOnly = true;
			this.Grid_ProductId.Width = 125;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// SoldedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.OnStore);
			this.Controls.Add(this.Accepted);
			this.Controls.Add(this.Report);
			this.Name = "SoldedForm";
			this.Text = "Solded";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Button OnStore;
		private Button Accepted;
		private Button Report;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Grid_Id;
		private DataGridViewTextBoxColumn Grid_Name;
		private DataGridViewTextBoxColumn Grid_Cost;
		private DataGridViewTextBoxColumn Grid_ProductId;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem deleteToolStripMenuItem;
	}
}