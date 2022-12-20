namespace MagazineGUI
{
    partial class BuildIssue
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
            this.components = new System.ComponentModel.Container();
            this.labelArea = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.dataGridPending = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePending = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePublished = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridPublished = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.buttonUnpublish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePublished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublished)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(35, 93);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(114, 25);
            this.labelArea.TabIndex = 3;
            this.labelArea.Text = "Select Area";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(180, 87);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(239, 33);
            this.comboBoxArea.TabIndex = 2;
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Issue Number ";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(444, 23);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(59, 29);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "num";
            this.labelNumber.Click += new System.EventHandler(this.labelNumber_Click);
            // 
            // dataGridPending
            // 
            this.dataGridPending.AutoGenerateColumns = false;
            this.dataGridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title});
            this.dataGridPending.DataSource = this.bindingSourcePending;
            this.dataGridPending.Location = new System.Drawing.Point(63, 183);
            this.dataGridPending.Name = "dataGridPending";
            this.dataGridPending.RowHeadersWidth = 51;
            this.dataGridPending.RowTemplate.Height = 24;
            this.dataGridPending.Size = new System.Drawing.Size(240, 316);
            this.dataGridPending.TabIndex = 6;
            this.dataGridPending.SelectionChanged += new System.EventHandler(this.dataGridPending_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "grid_Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "grid_title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // dataGridPublished
            // 
            this.dataGridPublished.AutoGenerateColumns = false;
            this.dataGridPublished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridPublished.DataSource = this.bindingSourcePublished;
            this.dataGridPublished.Location = new System.Drawing.Point(491, 183);
            this.dataGridPublished.Name = "dataGridPublished";
            this.dataGridPublished.RowHeadersWidth = 51;
            this.dataGridPublished.RowTemplate.Height = 24;
            this.dataGridPublished.Size = new System.Drawing.Size(240, 316);
            this.dataGridPublished.TabIndex = 7;
            this.dataGridPublished.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridPublished.SelectionChanged += new System.EventHandler(this.dataGridPublished_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(491, 591);
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
            this.buttonSave.Location = new System.Drawing.Point(333, 441);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 40);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublish.Location = new System.Drawing.Point(333, 277);
            this.buttonPublish.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(115, 40);
            this.buttonPublish.TabIndex = 23;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // buttonUnpublish
            // 
            this.buttonUnpublish.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpublish.Location = new System.Drawing.Point(333, 360);
            this.buttonUnpublish.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnpublish.Name = "buttonUnpublish";
            this.buttonUnpublish.Size = new System.Drawing.Size(115, 40);
            this.buttonUnpublish.TabIndex = 24;
            this.buttonUnpublish.Text = "Unpublish";
            this.buttonUnpublish.UseVisualStyleBackColor = true;
            this.buttonUnpublish.Click += new System.EventHandler(this.buttonUnpublish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Papers Pending Publication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Published Papers";
            // 
            // buttonBuild
            // 
            this.buttonBuild.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuild.Location = new System.Drawing.Point(641, 591);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(115, 40);
            this.buttonBuild.TabIndex = 27;
            this.buttonBuild.Text = "Save Issue";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(491, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker.TabIndex = 28;
            // 
            // BuildIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUnpublish);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridPublished);
            this.Controls.Add(this.dataGridPending);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.comboBoxArea);
            this.Name = "BuildIssue";
            this.Text = "BuildIssue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePublished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublished)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.DataGridView dataGridPending;
        private System.Windows.Forms.BindingSource bindingSourcePending;
        private System.Windows.Forms.BindingSource bindingSourcePublished;
        private System.Windows.Forms.DataGridView dataGridPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Button buttonUnpublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}