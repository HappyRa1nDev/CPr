namespace FormApps
{
	partial class PointForm
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
			this.listBox = new System.Windows.Forms.ListBox();
			this.Create = new System.Windows.Forms.Button();
			this.Sort = new System.Windows.Forms.Button();
			this.Serialize = new System.Windows.Forms.Button();
			this.Deserialize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 41;
			this.listBox.Location = new System.Drawing.Point(28, 50);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(910, 537);
			this.listBox.TabIndex = 0;
			// 
			// Create
			// 
			this.Create.Location = new System.Drawing.Point(72, 622);
			this.Create.Name = "Create";
			this.Create.Size = new System.Drawing.Size(188, 58);
			this.Create.TabIndex = 2;
			this.Create.Text = "Create";
			this.Create.UseVisualStyleBackColor = true;
			this.Create.Click += new System.EventHandler(this.Create_Click);
			// 
			// Sort
			// 
			this.Sort.Location = new System.Drawing.Point(294, 622);
			this.Sort.Name = "Sort";
			this.Sort.Size = new System.Drawing.Size(188, 58);
			this.Sort.TabIndex = 3;
			this.Sort.Text = "Sort";
			this.Sort.UseVisualStyleBackColor = true;
			this.Sort.Click += new System.EventHandler(this.Sort_Click);
			// 
			// Serialize
			// 
			this.Serialize.Location = new System.Drawing.Point(515, 622);
			this.Serialize.Name = "Serialize";
			this.Serialize.Size = new System.Drawing.Size(188, 58);
			this.Serialize.TabIndex = 4;
			this.Serialize.Text = "Serialize";
			this.Serialize.UseVisualStyleBackColor = true;
			this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
			// 
			// Deserialize
			// 
			this.Deserialize.Location = new System.Drawing.Point(750, 622);
			this.Deserialize.Name = "Deserialize";
			this.Deserialize.Size = new System.Drawing.Size(188, 58);
			this.Deserialize.TabIndex = 5;
			this.Deserialize.Text = "Deserialize";
			this.Deserialize.UseVisualStyleBackColor = true;
			this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
			// 
			// PointForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(992, 730);
			this.Controls.Add(this.Deserialize);
			this.Controls.Add(this.Serialize);
			this.Controls.Add(this.Sort);
			this.Controls.Add(this.Create);
			this.Controls.Add(this.listBox);
			this.Name = "PointForm";
			this.Text = "Point Form";
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox listBox;
		private Button Create;
		private Button Sort;
		private Button Serialize;
		private Button Deserialize;
	}
}