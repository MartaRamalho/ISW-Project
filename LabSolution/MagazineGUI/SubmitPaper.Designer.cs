namespace MagazineGUI
{
    partial class SubmitPaper
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
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxAuthor2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthor3 = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthor4 = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAuthor1 = new System.Windows.Forms.ComboBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(136, 36);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(369, 33);
            this.comboBoxArea.TabIndex = 0;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(16, 39);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(114, 25);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Select Area";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(81, 99);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(49, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(135, 94);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(370, 33);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxAuthor2
            // 
            this.comboBoxAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor2.FormattingEnabled = true;
            this.comboBoxAuthor2.Location = new System.Drawing.Point(20, 110);
            this.comboBoxAuthor2.Name = "comboBoxAuthor2";
            this.comboBoxAuthor2.Size = new System.Drawing.Size(244, 33);
            this.comboBoxAuthor2.TabIndex = 11;
            this.comboBoxAuthor2.SelectedIndexChanged += new System.EventHandler(this.changeSelectionA2);
            // 
            // comboBoxAuthor3
            // 
            this.comboBoxAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor3.FormattingEnabled = true;
            this.comboBoxAuthor3.Location = new System.Drawing.Point(19, 167);
            this.comboBoxAuthor3.Name = "comboBoxAuthor3";
            this.comboBoxAuthor3.Size = new System.Drawing.Size(244, 33);
            this.comboBoxAuthor3.TabIndex = 13;
            this.comboBoxAuthor3.SelectedIndexChanged += new System.EventHandler(this.ChangeSelectionA3);
            // 
            // comboBoxAuthor4
            // 
            this.comboBoxAuthor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor4.FormattingEnabled = true;
            this.comboBoxAuthor4.Location = new System.Drawing.Point(19, 226);
            this.comboBoxAuthor4.Name = "comboBoxAuthor4";
            this.comboBoxAuthor4.Size = new System.Drawing.Size(244, 33);
            this.comboBoxAuthor4.TabIndex = 15;
            this.comboBoxAuthor4.SelectedIndexChanged += new System.EventHandler(this.ChangeSelectionA4);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(276, 495);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 40);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(415, 495);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 40);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveClicked);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(40, 479);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(158, 56);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register New Person";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.RegisterClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxA4);
            this.groupBox1.Controls.Add(this.textBoxA3);
            this.groupBox1.Controls.Add(this.textBoxA2);
            this.groupBox1.Controls.Add(this.textBoxA1);
            this.groupBox1.Controls.Add(this.comboBoxAuthor1);
            this.groupBox1.Controls.Add(this.comboBoxAuthor2);
            this.groupBox1.Controls.Add(this.comboBoxAuthor3);
            this.groupBox1.Controls.Add(this.comboBoxAuthor4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 288);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Authors";
            // 
            // comboBoxAuthor1
            // 
            this.comboBoxAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor1.FormattingEnabled = true;
            this.comboBoxAuthor1.Location = new System.Drawing.Point(19, 52);
            this.comboBoxAuthor1.Name = "comboBoxAuthor1";
            this.comboBoxAuthor1.Size = new System.Drawing.Size(244, 33);
            this.comboBoxAuthor1.TabIndex = 9;
            this.comboBoxAuthor1.SelectedIndexChanged += new System.EventHandler(this.changeSelectionA1);
            // 
            // textBoxA1
            // 
            this.textBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA1.Location = new System.Drawing.Point(295, 52);
            this.textBoxA1.Multiline = true;
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.ReadOnly = true;
            this.textBoxA1.Size = new System.Drawing.Size(252, 33);
            this.textBoxA1.TabIndex = 16;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA2.Location = new System.Drawing.Point(295, 110);
            this.textBoxA2.Multiline = true;
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.ReadOnly = true;
            this.textBoxA2.Size = new System.Drawing.Size(252, 33);
            this.textBoxA2.TabIndex = 17;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA3.Location = new System.Drawing.Point(295, 167);
            this.textBoxA3.Multiline = true;
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.ReadOnly = true;
            this.textBoxA3.Size = new System.Drawing.Size(252, 33);
            this.textBoxA3.TabIndex = 18;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA4.Location = new System.Drawing.Point(295, 226);
            this.textBoxA4.Multiline = true;
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.ReadOnly = true;
            this.textBoxA4.Size = new System.Drawing.Size(252, 33);
            this.textBoxA4.TabIndex = 19;
            // 
            // SubmitPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.comboBoxArea);
            this.Name = "SubmitPaper";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SubmitPaper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxAuthor2;
        private System.Windows.Forms.ComboBox comboBoxAuthor3;
        private System.Windows.Forms.ComboBox comboBoxAuthor4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAuthor1;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA2;
    }
}