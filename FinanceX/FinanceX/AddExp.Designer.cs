
namespace FinanceX
{
    partial class AddExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExp));
            this.label1 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.EAmt = new System.Windows.Forms.TextBox();
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.ECategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddExpBtn = new System.Windows.Forms.Button();
            this.backlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Expense";
            // 
            // EName
            // 
            this.EName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EName.Location = new System.Drawing.Point(181, 109);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(169, 27);
            this.EName.TabIndex = 1;
            // 
            // EAmt
            // 
            this.EAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EAmt.Location = new System.Drawing.Point(181, 300);
            this.EAmt.Name = "EAmt";
            this.EAmt.Size = new System.Drawing.Size(169, 27);
            this.EAmt.TabIndex = 2;
            // 
            // EDate
            // 
            this.EDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EDate.Location = new System.Drawing.Point(181, 236);
            this.EDate.MaxDate = new System.DateTime(2023, 1, 26, 0, 0, 0, 0);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(169, 27);
            this.EDate.TabIndex = 3;
            // 
            // ECategory
            // 
            this.ECategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ECategory.FormattingEnabled = true;
            this.ECategory.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Medical",
            "Housing",
            "Travel",
            "Transportation",
            "Others"});
            this.ECategory.Location = new System.Drawing.Point(181, 172);
            this.ECategory.Name = "ECategory";
            this.ECategory.Size = new System.Drawing.Size(169, 28);
            this.ECategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // EDesc
            // 
            this.EDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDesc.Location = new System.Drawing.Point(181, 360);
            this.EDesc.Multiline = true;
            this.EDesc.Name = "EDesc";
            this.EDesc.Size = new System.Drawing.Size(169, 73);
            this.EDesc.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // AddExpBtn
            // 
            this.AddExpBtn.Location = new System.Drawing.Point(225, 459);
            this.AddExpBtn.Name = "AddExpBtn";
            this.AddExpBtn.Size = new System.Drawing.Size(67, 33);
            this.AddExpBtn.TabIndex = 11;
            this.AddExpBtn.Text = "Add";
            this.AddExpBtn.UseVisualStyleBackColor = true;
            this.AddExpBtn.Click += new System.EventHandler(this.AddExpBtn_Click);
            // 
            // backlbl
            // 
            this.backlbl.AutoSize = true;
            this.backlbl.Location = new System.Drawing.Point(7, 9);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(39, 17);
            this.backlbl.TabIndex = 18;
            this.backlbl.Text = "Back";
            this.backlbl.Click += new System.EventHandler(this.backlbl_Click);
            // 
            // AddExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 558);
            this.Controls.Add(this.backlbl);
            this.Controls.Add(this.AddExpBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ECategory);
            this.Controls.Add(this.EDate);
            this.Controls.Add(this.EAmt);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.TextBox EAmt;
        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.ComboBox ECategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddExpBtn;
        private System.Windows.Forms.Label backlbl;
    }
}