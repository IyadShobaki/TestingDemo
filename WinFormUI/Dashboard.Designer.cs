namespace WinFormUI
{
    partial class Dashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNumberValue = new System.Windows.Forms.NumericUpDown();
            this.firstNumberValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userDropdown = new System.Windows.Forms.ComboBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.divisionButton);
            this.groupBox1.Controls.Add(this.multiplicationButton);
            this.groupBox1.Controls.Add(this.subtractionButton);
            this.groupBox1.Controls.Add(this.AdditionButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.secondNumberValue);
            this.groupBox1.Controls.Add(this.firstNumberValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Section";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(306, 353);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(190, 43);
            this.resultText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(38, 379);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(211, 59);
            this.divisionButton.TabIndex = 7;
            this.divisionButton.Text = "Divide";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(38, 314);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(211, 59);
            this.multiplicationButton.TabIndex = 6;
            this.multiplicationButton.Text = "Multiply";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(38, 249);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(211, 59);
            this.subtractionButton.TabIndex = 5;
            this.subtractionButton.Text = "Subtract";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Location = new System.Drawing.Point(38, 184);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(211, 59);
            this.AdditionButton.TabIndex = 4;
            this.AdditionButton.Text = "Add";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            // 
            // secondNumberValue
            // 
            this.secondNumberValue.Location = new System.Drawing.Point(306, 121);
            this.secondNumberValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.secondNumberValue.Name = "secondNumberValue";
            this.secondNumberValue.Size = new System.Drawing.Size(190, 43);
            this.secondNumberValue.TabIndex = 1;
            // 
            // firstNumberValue
            // 
            this.firstNumberValue.Location = new System.Drawing.Point(306, 52);
            this.firstNumberValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.firstNumberValue.Name = "firstNumberValue";
            this.firstNumberValue.Size = new System.Drawing.Size(190, 43);
            this.firstNumberValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userDropdown);
            this.groupBox2.Controls.Add(this.lastNameText);
            this.groupBox2.Controls.Add(this.firstNameText);
            this.groupBox2.Controls.Add(this.addPersonButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(550, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Section";
            // 
            // userDropdown
            // 
            this.userDropdown.FormattingEnabled = true;
            this.userDropdown.Location = new System.Drawing.Point(122, 121);
            this.userDropdown.Name = "userDropdown";
            this.userDropdown.Size = new System.Drawing.Size(367, 45);
            this.userDropdown.TabIndex = 13;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(212, 290);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(277, 43);
            this.lastNameText.TabIndex = 12;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(212, 218);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(277, 43);
            this.firstNameText.TabIndex = 10;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(133, 353);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(251, 59);
            this.addPersonButton.TabIndex = 9;
            this.addPersonButton.Text = "AddPerson";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown secondNumberValue;
        private System.Windows.Forms.NumericUpDown firstNumberValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox userDropdown;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}