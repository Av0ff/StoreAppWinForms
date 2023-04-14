namespace StoreApp
{
	partial class AcceptedForm
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
			this.Report = new System.Windows.Forms.Button();
			this.Solded = new System.Windows.Forms.Button();
			this.OnStore = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Grid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grid_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddProduct = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.onStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Report
			// 
			this.Report.Location = new System.Drawing.Point(212, 409);
			this.Report.Name = "Report";
			this.Report.Size = new System.Drawing.Size(94, 29);
			this.Report.TabIndex = 7;
			this.Report.Text = "Report";
			this.Report.UseVisualStyleBackColor = true;
			this.Report.Click += new System.EventHandler(this.Report_Click);
			// 
			// Solded
			// 
			this.Solded.Location = new System.Drawing.Point(112, 409);
			this.Solded.Name = "Solded";
			this.Solded.Size = new System.Drawing.Size(94, 29);
			this.Solded.TabIndex = 6;
			this.Solded.Text = "Solded";
			this.Solded.UseVisualStyleBackColor = true;
			this.Solded.Click += new System.EventHandler(this.Solded_Click);
			// 
			// OnStore
			// 
			this.OnStore.Location = new System.Drawing.Point(12, 409);
			this.OnStore.Name = "OnStore";
			this.OnStore.Size = new System.Drawing.Size(94, 29);
			this.OnStore.TabIndex = 5;
			this.OnStore.Text = "On Store";
			this.OnStore.UseVisualStyleBackColor = true;
			this.OnStore.Click += new System.EventHandler(this.OnStore_Click);
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 29);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(557, 296);
			this.dataGridView1.TabIndex = 8;
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
			// AddProduct
			// 
			this.AddProduct.Location = new System.Drawing.Point(658, 296);
			this.AddProduct.Name = "AddProduct";
			this.AddProduct.Size = new System.Drawing.Size(120, 29);
			this.AddProduct.TabIndex = 9;
			this.AddProduct.Text = "Add Product";
			this.AddProduct.UseVisualStyleBackColor = true;
			this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onStoreToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
			// 
			// onStoreToolStripMenuItem
			// 
			this.onStoreToolStripMenuItem.Name = "onStoreToolStripMenuItem";
			this.onStoreToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.onStoreToolStripMenuItem.Text = "OnStore";
			this.onStoreToolStripMenuItem.Click += new System.EventHandler(this.onStoreToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// AcceptedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 450);
			this.Controls.Add(this.AddProduct);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Report);
			this.Controls.Add(this.Solded);
			this.Controls.Add(this.OnStore);
			this.Name = "AcceptedForm";
			this.Text = "Accepted";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Button Report;
		private Button Solded;
		private Button OnStore;
		internal DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Grid_Id;
		private DataGridViewTextBoxColumn Grid_Name;
		private DataGridViewTextBoxColumn Grid_Cost;
		private DataGridViewTextBoxColumn Grid_ProductId;
		private Button AddProduct;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem onStoreToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
	}
}