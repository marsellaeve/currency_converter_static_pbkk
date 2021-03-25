namespace Live_Currency_Converter
{
    partial class Form1
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
            this.amount_txt = new System.Windows.Forms.NumericUpDown();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.display_txt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(41, 121);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amount_txt.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(120, 25);
            this.amount_txt.TabIndex = 1;
            // 
            // fromcombo1
            // 
            this.fromcombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "US Dollar",
            "Rupiah",
            "Euro",
            "Ringgit"});
            this.fromcombo1.Location = new System.Drawing.Point(209, 120);
            this.fromcombo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(121, 30);
            this.fromcombo1.TabIndex = 2;
            // 
            // tocombo2
            // 
            this.tocombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "Rupiah",
            "US Dollar",
            "Euro",
            "Ringgit"});
            this.tocombo2.Location = new System.Drawing.Point(209, 194);
            this.tocombo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(121, 30);
            this.tocombo2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by Evelyn Tjitrodjojo 05111840000099";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Currency Converter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(41, 168);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(126, 22);
            this.display_txt.TabIndex = 8;
            this.display_txt.Text = "Converted Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 194);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 25);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insert Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Currency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.amount_txt);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amount_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount_txt;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

