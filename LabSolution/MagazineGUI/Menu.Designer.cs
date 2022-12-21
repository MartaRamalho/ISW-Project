namespace MagazineGUI
{
    partial class Menu
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
            this.buttonSubmitPaper = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuIAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmitPaper
            // 
            this.buttonSubmitPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitPaper.Location = new System.Drawing.Point(184, 189);
            this.buttonSubmitPaper.Name = "buttonSubmitPaper";
            this.buttonSubmitPaper.Size = new System.Drawing.Size(145, 75);
            this.buttonSubmitPaper.TabIndex = 4;
            this.buttonSubmitPaper.Text = "Submit Paper";
            this.buttonSubmitPaper.UseVisualStyleBackColor = true;
            this.buttonSubmitPaper.Click += new System.EventHandler(this.SubmitPaperClicked);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(126, 59);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(274, 92);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome to \r\nMagazine App";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuIAccount
            // 
            this.toolStripMenuIAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStrip,
            this.exitToolStripMenuItem});
            this.toolStripMenuIAccount.Name = "toolStripMenuIAccount";
            this.toolStripMenuIAccount.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuIAccount.Text = "Account";
            // 
            // logoutToolStrip
            // 
            this.logoutToolStrip.Name = "logoutToolStrip";
            this.logoutToolStrip.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStrip.Text = "Logout";
            this.logoutToolStrip.Click += new System.EventHandler(this.LogoutClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.buttonSubmitPaper);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIAccount;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonSubmitPaper;
    }
}