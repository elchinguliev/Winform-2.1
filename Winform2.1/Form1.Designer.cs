namespace Winform2._1
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
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.surnameTxb = new System.Windows.Forms.TextBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.numberTxb = new System.Windows.Forms.TextBox();
            this.birthdatetime = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.humanslistBox = new System.Windows.Forms.ListBox();
            this.filenameTxb = new System.Windows.Forms.TextBox();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(245, 65);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(100, 22);
            this.nameTxb.TabIndex = 0;
            this.nameTxb.TextChanged += new System.EventHandler(this.nameTxb_TextChanged);
            // 
            // surnameTxb
            // 
            this.surnameTxb.Location = new System.Drawing.Point(245, 108);
            this.surnameTxb.Name = "surnameTxb";
            this.surnameTxb.Size = new System.Drawing.Size(100, 22);
            this.surnameTxb.TabIndex = 0;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(245, 161);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(100, 22);
            this.emailTxb.TabIndex = 0;
            // 
            // numberTxb
            // 
            this.numberTxb.Location = new System.Drawing.Point(245, 206);
            this.numberTxb.Name = "numberTxb";
            this.numberTxb.Size = new System.Drawing.Size(100, 22);
            this.numberTxb.TabIndex = 0;
            // 
            // birthdatetime
            // 
            this.birthdatetime.Location = new System.Drawing.Point(245, 251);
            this.birthdatetime.Margin = new System.Windows.Forms.Padding(4);
            this.birthdatetime.Multiline = true;
            this.birthdatetime.Name = "birthdatetime";
            this.birthdatetime.Size = new System.Drawing.Size(100, 22);
            this.birthdatetime.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(109, 65);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 20);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(108, 108);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(83, 20);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(109, 163);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(56, 20);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(109, 206);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(120, 20);
            this.numberLbl.TabIndex = 1;
            this.numberLbl.Text = "Mobile phone";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLbl.Location = new System.Drawing.Point(109, 253);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(132, 20);
            this.birthdateLbl.TabIndex = 1;
            this.birthdateLbl.Text = "Birth and Date";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(161, 336);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 43);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Black;
            this.changeBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBtn.Location = new System.Drawing.Point(175, 387);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(100, 43);
            this.changeBtn.TabIndex = 7;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Black;
            this.loadBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(338, 394);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(123, 50);
            this.loadBtn.TabIndex = 9;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(484, 401);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 43);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Black;
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(630, 394);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(123, 43);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Black;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLbl.Location = new System.Drawing.Point(375, 42);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(391, 43);
            this.headerLbl.TabIndex = 12;
            this.headerLbl.Text = "List of Humans";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humanslistBox
            // 
            this.humanslistBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humanslistBox.FormattingEnabled = true;
            this.humanslistBox.ItemHeight = 23;
            this.humanslistBox.Location = new System.Drawing.Point(380, 108);
            this.humanslistBox.Margin = new System.Windows.Forms.Padding(4);
            this.humanslistBox.Name = "humanslistBox";
            this.humanslistBox.Size = new System.Drawing.Size(389, 234);
            this.humanslistBox.TabIndex = 13;
            this.humanslistBox.SelectedIndexChanged += new System.EventHandler(this.humanslistBox_SelectedIndexChanged);
            this.humanslistBox.DoubleClick += new System.EventHandler(this.humanslistBox_DoubleClick);
            // 
            // filenameTxb
            // 
            this.filenameTxb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filenameTxb.Location = new System.Drawing.Point(495, 355);
            this.filenameTxb.Margin = new System.Windows.Forms.Padding(4);
            this.filenameTxb.Name = "filenameTxb";
            this.filenameTxb.Size = new System.Drawing.Size(240, 31);
            this.filenameTxb.TabIndex = 14;
            // 
            // filenameLbl
            // 
            this.filenameLbl.AutoSize = true;
            this.filenameLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filenameLbl.Location = new System.Drawing.Point(355, 358);
            this.filenameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(118, 23);
            this.filenameLbl.TabIndex = 15;
            this.filenameLbl.Text = "Name of File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.filenameTxb);
            this.Controls.Add(this.humanslistBox);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.birthdatetime);
            this.Controls.Add(this.numberTxb);
            this.Controls.Add(this.emailTxb);
            this.Controls.Add(this.surnameTxb);
            this.Controls.Add(this.nameTxb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.TextBox surnameTxb;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox numberTxb;
        private System.Windows.Forms.TextBox birthdatetime;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.ListBox humanslistBox;
        private System.Windows.Forms.TextBox filenameTxb;
        private System.Windows.Forms.Label filenameLbl;
    }
}

