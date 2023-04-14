namespace StoreApp
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Accepted = new System.Windows.Forms.Button();
			this.OnStore = new System.Windows.Forms.Button();
			this.Solded = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Guid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Guid_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Guid_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Guid_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Filter = new System.Windows.Forms.GroupBox();
			this.StatusSolded = new System.Windows.Forms.RadioButton();
			this.StatusOnStore = new System.Windows.Forms.RadioButton();
			this.StatusAccepted = new System.Windows.Forms.RadioButton();
			this.StatusAll = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SumCost = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Filter.SuspendLayout();
			this.SuspendLayout();
			// 
			// Accepted
			// 
			this.Accepted.Location = new System.Drawing.Point(12, 409);
			this.Accepted.Name = "Accepted";
			this.Accepted.Size = new System.Drawing.Size(94, 29);
			this.Accepted.TabIndex = 0;
			this.Accepted.Text = "Accepted";
			this.Accepted.UseVisualStyleBackColor = true;
			this.Accepted.Click += new System.EventHandler(this.Accepted_Click);
			// 
			// OnStore
			// 
			this.OnStore.Location = new System.Drawing.Point(112, 409);
			this.OnStore.Name = "OnStore";
			this.OnStore.Size = new System.Drawing.Size(94, 29);
			this.OnStore.TabIndex = 1;
			this.OnStore.Text = "On Store";
			this.OnStore.UseVisualStyleBackColor = true;
			this.OnStore.Click += new System.EventHandler(this.OnStore_Click);
			// 
			// Solded
			// 
			this.Solded.Location = new System.Drawing.Point(212, 409);
			this.Solded.Name = "Solded";
			this.Solded.Size = new System.Drawing.Size(94, 29);
			this.Solded.TabIndex = 2;
			this.Solded.Text = "Solded";
			this.Solded.UseVisualStyleBackColor = true;
			this.Solded.Click += new System.EventHandler(this.Solded_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guid_Id,
            this.Guid_Name,
            this.Guid_Cost,
            this.Guid_Status});
			this.dataGridView1.Location = new System.Drawing.Point(24, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(616, 294);
			this.dataGridView1.TabIndex = 3;
			// 
			// Guid_Id
			// 
			this.Guid_Id.HeaderText = "Id";
			this.Guid_Id.MinimumWidth = 6;
			this.Guid_Id.Name = "Guid_Id";
			this.Guid_Id.ReadOnly = true;
			this.Guid_Id.Width = 125;
			// 
			// Guid_Name
			// 
			this.Guid_Name.HeaderText = "Name";
			this.Guid_Name.MinimumWidth = 6;
			this.Guid_Name.Name = "Guid_Name";
			this.Guid_Name.ReadOnly = true;
			this.Guid_Name.Width = 125;
			// 
			// Guid_Cost
			// 
			this.Guid_Cost.HeaderText = "Cost";
			this.Guid_Cost.MinimumWidth = 6;
			this.Guid_Cost.Name = "Guid_Cost";
			this.Guid_Cost.ReadOnly = true;
			this.Guid_Cost.Width = 125;
			// 
			// Guid_Status
			// 
			this.Guid_Status.HeaderText = "Status";
			this.Guid_Status.MinimumWidth = 6;
			this.Guid_Status.Name = "Guid_Status";
			this.Guid_Status.ReadOnly = true;
			this.Guid_Status.Width = 125;
			// 
			// Filter
			// 
			this.Filter.Controls.Add(this.StatusSolded);
			this.Filter.Controls.Add(this.StatusOnStore);
			this.Filter.Controls.Add(this.StatusAccepted);
			this.Filter.Controls.Add(this.StatusAll);
			this.Filter.Location = new System.Drawing.Point(646, 56);
			this.Filter.Name = "Filter";
			this.Filter.Size = new System.Drawing.Size(142, 261);
			this.Filter.TabIndex = 4;
			this.Filter.TabStop = false;
			this.Filter.Text = "Filter";
			// 
			// StatusSolded
			// 
			this.StatusSolded.AutoSize = true;
			this.StatusSolded.Location = new System.Drawing.Point(13, 197);
			this.StatusSolded.Name = "StatusSolded";
			this.StatusSolded.Size = new System.Drawing.Size(77, 24);
			this.StatusSolded.TabIndex = 11;
			this.StatusSolded.TabStop = true;
			this.StatusSolded.Text = "Solded";
			this.StatusSolded.UseVisualStyleBackColor = true;
			this.StatusSolded.CheckedChanged += new System.EventHandler(this.StatusAll_CheckedChanged);
			// 
			// StatusOnStore
			// 
			this.StatusOnStore.AutoSize = true;
			this.StatusOnStore.Location = new System.Drawing.Point(13, 142);
			this.StatusOnStore.Name = "StatusOnStore";
			this.StatusOnStore.Size = new System.Drawing.Size(84, 24);
			this.StatusOnStore.TabIndex = 10;
			this.StatusOnStore.TabStop = true;
			this.StatusOnStore.Text = "OnStore";
			this.StatusOnStore.UseVisualStyleBackColor = true;
			this.StatusOnStore.CheckedChanged += new System.EventHandler(this.StatusAll_CheckedChanged);
			// 
			// StatusAccepted
			// 
			this.StatusAccepted.AutoSize = true;
			this.StatusAccepted.Location = new System.Drawing.Point(13, 87);
			this.StatusAccepted.Name = "StatusAccepted";
			this.StatusAccepted.Size = new System.Drawing.Size(93, 24);
			this.StatusAccepted.TabIndex = 9;
			this.StatusAccepted.TabStop = true;
			this.StatusAccepted.Text = "Accepted";
			this.StatusAccepted.UseVisualStyleBackColor = true;
			this.StatusAccepted.CheckedChanged += new System.EventHandler(this.StatusAll_CheckedChanged);
			// 
			// StatusAll
			// 
			this.StatusAll.AutoSize = true;
			this.StatusAll.Location = new System.Drawing.Point(13, 40);
			this.StatusAll.Name = "StatusAll";
			this.StatusAll.Size = new System.Drawing.Size(48, 24);
			this.StatusAll.TabIndex = 8;
			this.StatusAll.TabStop = true;
			this.StatusAll.Text = "All";
			this.StatusAll.UseVisualStyleBackColor = true;
			this.StatusAll.CheckedChanged += new System.EventHandler(this.StatusAll_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(347, 331);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sum Cost";
			// 
			// SumCost
			// 
			this.SumCost.Enabled = false;
			this.SumCost.Location = new System.Drawing.Point(321, 354);
			this.SumCost.Name = "SumCost";
			this.SumCost.Size = new System.Drawing.Size(125, 27);
			this.SumCost.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SumCost);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Filter);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Solded);
			this.Controls.Add(this.OnStore);
			this.Controls.Add(this.Accepted);
			this.Name = "MainForm";
			this.Text = "Report";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Filter.ResumeLayout(false);
			this.Filter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button Accepted;
		private Button OnStore;
		private Button Solded;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Guid_Id;
		private DataGridViewTextBoxColumn Guid_Name;
		private DataGridViewTextBoxColumn Guid_Cost;
		private DataGridViewTextBoxColumn Guid_Status;
		private GroupBox Filter;
		private RadioButton StatusSolded;
		private RadioButton StatusOnStore;
		private RadioButton StatusAccepted;
		private RadioButton StatusAll;
		private Label label1;
		private TextBox SumCost;
	}
}