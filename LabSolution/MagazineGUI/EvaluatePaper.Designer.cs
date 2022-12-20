namespace MagazineGUI
{
    partial class EvaluatePaper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.radioButtonAccept = new System.Windows.Forms.RadioButton();
            this.radioButtonReject = new System.Windows.Forms.RadioButton();
            this.Decision = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Decision.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comments";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(28, 105);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(537, 168);
            this.textBoxComments.TabIndex = 2;
            // 
            // radioButtonAccept
            // 
            this.radioButtonAccept.AutoSize = true;
            this.radioButtonAccept.Checked = true;
            this.radioButtonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAccept.Location = new System.Drawing.Point(17, 52);
            this.radioButtonAccept.Name = "radioButtonAccept";
            this.radioButtonAccept.Size = new System.Drawing.Size(106, 26);
            this.radioButtonAccept.TabIndex = 4;
            this.radioButtonAccept.TabStop = true;
            this.radioButtonAccept.Text = "Accepted";
            this.radioButtonAccept.UseVisualStyleBackColor = true;
            // 
            // radioButtonReject
            // 
            this.radioButtonReject.AutoSize = true;
            this.radioButtonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReject.Location = new System.Drawing.Point(17, 87);
            this.radioButtonReject.Name = "radioButtonReject";
            this.radioButtonReject.Size = new System.Drawing.Size(102, 26);
            this.radioButtonReject.TabIndex = 5;
            this.radioButtonReject.TabStop = true;
            this.radioButtonReject.Text = "Rejected";
            this.radioButtonReject.UseVisualStyleBackColor = true;
            // 
            // Decision
            // 
            this.Decision.Controls.Add(this.radioButtonReject);
            this.Decision.Controls.Add(this.radioButtonAccept);
            this.Decision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decision.Location = new System.Drawing.Point(28, 297);
            this.Decision.Name = "Decision";
            this.Decision.Size = new System.Drawing.Size(186, 138);
            this.Decision.TabIndex = 6;
            this.Decision.TabStop = false;
            this.Decision.Text = "Decision";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(318, 437);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 40);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(466, 437);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 40);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 502);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Decision);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EvaluatePaper";
            this.Text = "EvaluatePaper";
            this.Decision.ResumeLayout(false);
            this.Decision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.RadioButton radioButtonAccept;
        private System.Windows.Forms.RadioButton radioButtonReject;
        private System.Windows.Forms.GroupBox Decision;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonSave;
    }
}