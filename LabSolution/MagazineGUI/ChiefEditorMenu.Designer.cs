namespace MagazineGUI
{
    partial class ChiefEditorMenu
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
            this.buttonListPapers = new System.Windows.Forms.Button();
            this.buttonBuildIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListPapers
            // 
            this.buttonListPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListPapers.Location = new System.Drawing.Point(184, 390);
            this.buttonListPapers.Name = "buttonListPapers";
            this.buttonListPapers.Size = new System.Drawing.Size(145, 75);
            this.buttonListPapers.TabIndex = 6;
            this.buttonListPapers.Text = "List Papers";
            this.buttonListPapers.UseVisualStyleBackColor = true;
            this.buttonListPapers.Click += new System.EventHandler(this.ListPapersClicked);
            // 
            // buttonBuildIssue
            // 
            this.buttonBuildIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuildIssue.Location = new System.Drawing.Point(184, 288);
            this.buttonBuildIssue.Name = "buttonBuildIssue";
            this.buttonBuildIssue.Size = new System.Drawing.Size(145, 75);
            this.buttonBuildIssue.TabIndex = 7;
            this.buttonBuildIssue.Text = "Build Issue";
            this.buttonBuildIssue.UseVisualStyleBackColor = true;
            this.buttonBuildIssue.Click += new System.EventHandler(this.BuildIssueClicked);
            // 
            // ChiefEditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.buttonBuildIssue);
            this.Controls.Add(this.buttonListPapers);
            this.Name = "ChiefEditorMenu";
            this.Controls.SetChildIndex(this.buttonListPapers, 0);
            this.Controls.SetChildIndex(this.buttonBuildIssue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListPapers;
        private System.Windows.Forms.Button buttonBuildIssue;
    }
}