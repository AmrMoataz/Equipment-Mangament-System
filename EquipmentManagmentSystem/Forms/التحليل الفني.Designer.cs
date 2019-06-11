namespace EquipmentManagmentSystem.Forms
{
    partial class التحليل_الفني
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(التحليل_الفني));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CompNameCBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainLayout1 = new EquipmentManagmentSystem.MainLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 55);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(855, 375);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // CompNameCBox
            // 
            this.CompNameCBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompNameCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompNameCBox.FormattingEnabled = true;
            this.CompNameCBox.Location = new System.Drawing.Point(292, 29);
            this.CompNameCBox.Name = "CompNameCBox";
            this.CompNameCBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompNameCBox.Size = new System.Drawing.Size(474, 21);
            this.CompNameCBox.TabIndex = 2;
            this.CompNameCBox.SelectedIndexChanged += new System.EventHandler(this.CompNameCBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(772, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "أختر منافسة";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainLayout1
            // 
            this.mainLayout1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.mainLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout1.ForeColor = System.Drawing.SystemColors.Control;
            this.mainLayout1.Location = new System.Drawing.Point(0, 0);
            this.mainLayout1.Name = "mainLayout1";
            this.mainLayout1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainLayout1.Size = new System.Drawing.Size(951, 456);
            this.mainLayout1.TabIndex = 0;
            this.mainLayout1.Load += new System.EventHandler(this.mainLayout1_Load);
            this.mainLayout1.BackColorChanged += new System.EventHandler(this.mainLayout1_BackColorChanged);
            // 
            // التحليل_الفني
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CompNameCBox);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.mainLayout1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "التحليل_الفني";
            this.Text = "التحليل الفني";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.التحليل_الفني_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainLayout mainLayout1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox CompNameCBox;
        private System.Windows.Forms.TextBox textBox1;
        //     private Reports.RPT1 RPT11;
        //    private CrystalReport2 CrystalReport21;
        // private تقرير_التحليل_الفني تقرير_التحليل_الفني1;
        // private تقرير_التحليل_الفني تقرير_التحليل_الفني2;
        //private CrystalReport1 CrystalReport11;
        //private CrystalReport1 CrystalReport12;
        //private CrystalReport1 CrystalReport13;
    }
}