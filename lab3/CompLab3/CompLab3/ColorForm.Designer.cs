
namespace CompLab3
{
    partial class ColorForm
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
            this.components = new System.ComponentModel.Container();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.rBox = new ColorBoxNew(components);
            this.gBox = new ColorBoxNew(components);
            this.bBox = new ColorBoxNew(components);
            this.decBtn = new System.Windows.Forms.RadioButton();
            this.hexBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Black;
            this.ColorPanel.Location = new System.Drawing.Point(127, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(103, 109);
            this.ColorPanel.TabIndex = 0;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(63, 12);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(58, 23);
            this.rBox.TabIndex = 1;
            this.rBox.TextChanged += new System.EventHandler(this.rBox_TextChanged);
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(63, 41);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(58, 23);
            this.gBox.TabIndex = 2;
            this.gBox.TextChanged += new System.EventHandler(this.gBox_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(63, 70);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(58, 23);
            this.bBox.TabIndex = 3;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            // 
            // decBtn
            // 
            this.decBtn.AutoSize = true;
            this.decBtn.Checked = true;
            this.decBtn.Location = new System.Drawing.Point(12, 99);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(47, 19);
            this.decBtn.TabIndex = 4;
            this.decBtn.TabStop = true;
            this.decBtn.Text = "DEC";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.CheckedChanged += new System.EventHandler(this.decBtn_CheckedChanged);
            // 
            // hexBtn
            // 
            this.hexBtn.AutoSize = true;
            this.hexBtn.Location = new System.Drawing.Point(74, 99);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(47, 19);
            this.hexBtn.TabIndex = 5;
            this.hexBtn.TabStop = true;
            this.hexBtn.Text = "HEX";
            this.hexBtn.UseVisualStyleBackColor = true;
            this.hexBtn.CheckedChanged += new System.EventHandler(this.hexBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue";
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 133);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.ColorPanel);
            this.Name = "Color";
            this.Text = "CheckColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ColorPanel;
        private ColorBoxNew rBox;
        private ColorBoxNew gBox;
        private ColorBoxNew bBox;
        private System.Windows.Forms.RadioButton decBtn;
        private System.Windows.Forms.RadioButton hexBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

