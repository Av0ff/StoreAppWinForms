namespace StoreApp
{
	partial class CreationForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.textCost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.dropStatus = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// textName
			// 
			this.textName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textName.Location = new System.Drawing.Point(98, 98);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(125, 27);
			this.textName.TabIndex = 1;
			// 
			// textCost
			// 
			this.textCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textCost.Location = new System.Drawing.Point(98, 191);
			this.textCost.Name = "textCost";
			this.textCost.Size = new System.Drawing.Size(125, 27);
			this.textCost.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(132, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cost";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(132, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Status";
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.buttonOK.Location = new System.Drawing.Point(111, 362);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 29);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Create";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.button1_Click);
			// 
			// dropStatus
			// 
			this.dropStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dropStatus.FormattingEnabled = true;
			this.dropStatus.Location = new System.Drawing.Point(85, 280);
			this.dropStatus.Name = "dropStatus";
			this.dropStatus.Size = new System.Drawing.Size(151, 28);
			this.dropStatus.TabIndex = 7;
			// 
			// CreationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 445);
			this.Controls.Add(this.dropStatus);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textCost);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Name = "CreationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Creation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox textName;
		private TextBox textCost;
		private Label label2;
		private Label label3;
		private Button buttonOK;
		private ComboBox dropStatus;
	}
}