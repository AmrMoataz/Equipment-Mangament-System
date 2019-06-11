namespace EquipmentManagmentSystem.UserControls
{
    partial class helperControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpRdbtn = new System.Windows.Forms.RadioButton();
            this.memRdbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sidetxt = new System.Windows.Forms.TextBox();
            this.helperNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.addBtn.Location = new System.Drawing.Point(35, 106);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(26, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.helpRdbtn);
            this.groupBox1.Controls.Add(this.memRdbtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.sidetxt);
            this.groupBox1.Controls.Add(this.helperNametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(579, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العضو";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // helpRdbtn
            // 
            this.helpRdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpRdbtn.AutoSize = true;
            this.helpRdbtn.Location = new System.Drawing.Point(155, 96);
            this.helpRdbtn.Name = "helpRdbtn";
            this.helpRdbtn.Size = new System.Drawing.Size(55, 17);
            this.helpRdbtn.TabIndex = 8;
            this.helpRdbtn.TabStop = true;
            this.helpRdbtn.Text = "مساعد";
            this.helpRdbtn.UseVisualStyleBackColor = true;
            // 
            // memRdbtn
            // 
            this.memRdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memRdbtn.AutoSize = true;
            this.memRdbtn.Location = new System.Drawing.Point(130, 63);
            this.memRdbtn.Name = "memRdbtn";
            this.memRdbtn.Size = new System.Drawing.Size(80, 17);
            this.memRdbtn.TabIndex = 7;
            this.memRdbtn.TabStop = true;
            this.memRdbtn.Text = "عضو باللجنة";
            this.memRdbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع العضو";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(304, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 5;
            // 
            // sidetxt
            // 
            this.sidetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidetxt.Location = new System.Drawing.Point(304, 71);
            this.sidetxt.Name = "sidetxt";
            this.sidetxt.Size = new System.Drawing.Size(191, 20);
            this.sidetxt.TabIndex = 4;
            // 
            // helperNametxt
            // 
            this.helperNametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helperNametxt.Location = new System.Drawing.Point(304, 29);
            this.helperNametxt.Name = "helperNametxt";
            this.helperNametxt.Size = new System.Drawing.Size(191, 20);
            this.helperNametxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "تمثيله باللجنة";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "جهة";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // helperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "helperControl";
            this.Size = new System.Drawing.Size(579, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton helpRdbtn;
        private System.Windows.Forms.RadioButton memRdbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox sidetxt;
        private System.Windows.Forms.TextBox helperNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
