namespace Client
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.TvListBox = new System.Windows.Forms.ListBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.EditRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.FindRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 297);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(290, 101);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // TvListBox
            // 
            this.TvListBox.FormattingEnabled = true;
            this.TvListBox.ItemHeight = 16;
            this.TvListBox.Location = new System.Drawing.Point(12, 12);
            this.TvListBox.Name = "TvListBox";
            this.TvListBox.Size = new System.Drawing.Size(290, 244);
            this.TvListBox.TabIndex = 1;
            this.TvListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.Location = new System.Drawing.Point(330, 12);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(104, 24);
            this.AddRadioButton.TabIndex = 2;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // EditRadioButton
            // 
            this.EditRadioButton.Location = new System.Drawing.Point(330, 42);
            this.EditRadioButton.Name = "EditRadioButton";
            this.EditRadioButton.Size = new System.Drawing.Size(104, 24);
            this.EditRadioButton.TabIndex = 3;
            this.EditRadioButton.TabStop = true;
            this.EditRadioButton.Text = "Edit";
            this.EditRadioButton.UseVisualStyleBackColor = true;
            this.EditRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.Location = new System.Drawing.Point(330, 72);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(104, 24);
            this.DeleteRadioButton.TabIndex = 4;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "Delete";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            this.DeleteRadioButton.CheckedChanged += new System.EventHandler(this.DeleteRadioButton_CheckedChanged);
            // 
            // FindRadioButton
            // 
            this.FindRadioButton.Location = new System.Drawing.Point(330, 102);
            this.FindRadioButton.Name = "FindRadioButton";
            this.FindRadioButton.Size = new System.Drawing.Size(104, 24);
            this.FindRadioButton.TabIndex = 5;
            this.FindRadioButton.TabStop = true;
            this.FindRadioButton.Text = "Find";
            this.FindRadioButton.UseVisualStyleBackColor = true;
            this.FindRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(422, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "brand";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(422, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "log:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FindRadioButton);
            this.Controls.Add(this.DeleteRadioButton);
            this.Controls.Add(this.EditRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.TvListBox);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton FindRadioButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox TvListBox;

        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.RadioButton EditRadioButton;

        #endregion
    }
}