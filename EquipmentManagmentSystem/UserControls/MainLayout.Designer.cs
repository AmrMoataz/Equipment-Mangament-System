namespace EquipmentManagmentSystem
{
    partial class MainLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tech_analysis_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.InputToolStripMenuItem,
            this.Tech_analysis_ToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            resources.ApplyResources(this.HomeToolStripMenuItem, "HomeToolStripMenuItem");
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // InputToolStripMenuItem
            // 
            resources.ApplyResources(this.InputToolStripMenuItem, "InputToolStripMenuItem");
            this.InputToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 115, 20, 15);
            this.InputToolStripMenuItem.Name = "InputToolStripMenuItem";
            this.InputToolStripMenuItem.Click += new System.EventHandler(this.InputToolStripMenuItem_Click);
            // 
            // Tech_analysis_ToolStripMenuItem
            // 
            this.Tech_analysis_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tech_analysis_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 30, 0, 15);
            this.Tech_analysis_ToolStripMenuItem.Name = "Tech_analysis_ToolStripMenuItem";
            resources.ApplyResources(this.Tech_analysis_ToolStripMenuItem, "Tech_analysis_ToolStripMenuItem");
            this.Tech_analysis_ToolStripMenuItem.Click += new System.EventHandler(this.Tech_analysis_ToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // MainLayout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainLayout";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InputToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tech_analysis_ToolStripMenuItem;
    }
}
