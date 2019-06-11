namespace EquipmentManagmentSystem.Forms
{
    partial class AddHelper
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
            this.membersGbox = new System.Windows.Forms.GroupBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.rankCbox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.helpRdbtn = new System.Windows.Forms.RadioButton();
            this.memRdbtn = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.sidetxt = new System.Windows.Forms.TextBox();
            this.helperNametxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.membersGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // membersGbox
            // 
            this.membersGbox.Controls.Add(this.backBtn);
            this.membersGbox.Controls.Add(this.label28);
            this.membersGbox.Controls.Add(this.rankCbox);
            this.membersGbox.Controls.Add(this.addBtn);
            this.membersGbox.Controls.Add(this.helpRdbtn);
            this.membersGbox.Controls.Add(this.memRdbtn);
            this.membersGbox.Controls.Add(this.label13);
            this.membersGbox.Controls.Add(this.sidetxt);
            this.membersGbox.Controls.Add(this.helperNametxt);
            this.membersGbox.Controls.Add(this.label14);
            this.membersGbox.Controls.Add(this.label15);
            this.membersGbox.Controls.Add(this.label16);
            this.membersGbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGbox.Location = new System.Drawing.Point(0, 0);
            this.membersGbox.Name = "membersGbox";
            this.membersGbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membersGbox.Size = new System.Drawing.Size(1076, 175);
            this.membersGbox.TabIndex = 4;
            this.membersGbox.TabStop = false;
            this.membersGbox.Text = "بيانات العضو";
            this.membersGbox.UseCompatibleTextRendering = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(49, 111);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 23);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "رجوع";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(997, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "*";
            // 
            // rankCbox
            // 
            this.rankCbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rankCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rankCbox.FormattingEnabled = true;
            this.rankCbox.Items.AddRange(new object[] {
            "رئيسا",
            "عضوا"});
            this.rankCbox.Location = new System.Drawing.Point(647, 109);
            this.rankCbox.Name = "rankCbox";
            this.rankCbox.Size = new System.Drawing.Size(327, 21);
            this.rankCbox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(217, 111);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "حفظ";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // helpRdbtn
            // 
            this.helpRdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpRdbtn.AutoSize = true;
            this.helpRdbtn.Location = new System.Drawing.Point(498, 94);
            this.helpRdbtn.Name = "helpRdbtn";
            this.helpRdbtn.Size = new System.Drawing.Size(55, 17);
            this.helpRdbtn.TabIndex = 8;
            this.helpRdbtn.TabStop = true;
            this.helpRdbtn.Text = "مساعد";
            this.helpRdbtn.UseVisualStyleBackColor = true;
            // 
            // memRdbtn
            // 
            this.memRdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memRdbtn.AutoSize = true;
            this.memRdbtn.Location = new System.Drawing.Point(473, 61);
            this.memRdbtn.Name = "memRdbtn";
            this.memRdbtn.Size = new System.Drawing.Size(80, 17);
            this.memRdbtn.TabIndex = 7;
            this.memRdbtn.TabStop = true;
            this.memRdbtn.Text = "عضو باللجنة";
            this.memRdbtn.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(519, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "نوع العضو";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // sidetxt
            // 
            this.sidetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidetxt.Location = new System.Drawing.Point(647, 69);
            this.sidetxt.Name = "sidetxt";
            this.sidetxt.Size = new System.Drawing.Size(327, 20);
            this.sidetxt.TabIndex = 4;
            // 
            // helperNametxt
            // 
            this.helperNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helperNametxt.Location = new System.Drawing.Point(647, 27);
            this.helperNametxt.Name = "helperNametxt";
            this.helperNametxt.Size = new System.Drawing.Size(327, 20);
            this.helperNametxt.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(988, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "تمثيله باللجنة";
            this.label14.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1014, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "جهة";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1014, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "الاسم";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // AddHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 175);
            this.Controls.Add(this.membersGbox);
            this.MaximizeBox = false;
            this.Name = "AddHelper";
            this.Text = "إضافة عضو";
            this.membersGbox.ResumeLayout(false);
            this.membersGbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox membersGbox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox rankCbox;
        private System.Windows.Forms.RadioButton helpRdbtn;
        private System.Windows.Forms.RadioButton memRdbtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sidetxt;
        private System.Windows.Forms.TextBox helperNametxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
    }
}