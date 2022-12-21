namespace MagazineGUI
{
    partial class AreaEditorMenu
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
            this.buttonEvaluatePaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEvaluatePaper
            // 
            this.buttonEvaluatePaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvaluatePaper.Location = new System.Drawing.Point(184, 295);
            this.buttonEvaluatePaper.Name = "buttonEvaluatePaper";
            this.buttonEvaluatePaper.Size = new System.Drawing.Size(145, 75);
            this.buttonEvaluatePaper.TabIndex = 5;
            this.buttonEvaluatePaper.Text = "Evaluate Paper";
            this.buttonEvaluatePaper.UseVisualStyleBackColor = true;
            this.buttonEvaluatePaper.Click += new System.EventHandler(this.EvaluatePaperClicked);
            // 
            // AreaEditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.buttonEvaluatePaper);
            this.Name = "AreaEditorMenu";
            this.Controls.SetChildIndex(this.buttonEvaluatePaper, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEvaluatePaper;
    }
}