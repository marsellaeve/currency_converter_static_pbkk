namespace dynamic_currency_converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter with API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(228, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Converted Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Currency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Made by Evelyn Tjitrodjojo 05111840000099";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(49, 100);
            this.input.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(122, 25);
            this.input.TabIndex = 7;
            // 
            // fromComboBox
            // 
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(228, 100);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(122, 30);
            this.fromComboBox.TabIndex = 8;
            // 
            // toComboBox
            // 
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(228, 169);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(122, 30);
            this.toComboBox.TabIndex = 9;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(49, 169);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(122, 30);
            this.output.TabIndex = 10;
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(113, 236);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(165, 25);
            this.datepicker.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 361);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.output);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label7;
    }
}

