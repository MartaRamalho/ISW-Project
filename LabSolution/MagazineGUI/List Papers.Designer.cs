namespace MagazineGUI
{
    partial class List_Papers
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPapers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 165);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(413, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(131, 54);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(349, 43);
            this.comboBoxArea.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(61, 54);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(62, 32);
            this.labelArea.TabIndex = 3;
            this.labelArea.Text = "Area";
            this.labelArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPapers
            // 
            this.labelPapers.AutoSize = true;
            this.labelPapers.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPapers.Location = new System.Drawing.Point(61, 119);
            this.labelPapers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPapers.Name = "labelPapers";
            this.labelPapers.Size = new System.Drawing.Size(84, 32);
            this.labelPapers.TabIndex = 4;
            this.labelPapers.Text = "Papers";
            this.labelPapers.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // List_Papers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 663);
            this.Controls.Add(this.labelPapers);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "List_Papers";
            this.Text = "List_Papers";
            this.Load += new System.EventHandler(this.List_Papers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelPapers;
    }
}