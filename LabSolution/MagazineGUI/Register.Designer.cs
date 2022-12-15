namespace MagazineGUI
{
    partial class Register
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.radioButtonNotify = new System.Windows.Forms.RadioButton();
            this.checkedListAreas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(76, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(58, 99);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(73, 21);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(145, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(259, 32);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(145, 94);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(259, 32);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(145, 144);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(375, 32);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(10, 294);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(123, 21);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Areas of Interest";
            this.labelArea.Click += new System.EventHandler(this.labelArea_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(145, 241);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(259, 32);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(145, 193);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(259, 32);
            this.textBoxUsername.TabIndex = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(54, 245);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 21);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(50, 193);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 21);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label6_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(488, 486);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 42);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterClicked);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(370, 486);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 42);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // radioButtonNotify
            // 
            this.radioButtonNotify.AutoSize = true;
            this.radioButtonNotify.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.radioButtonNotify.Location = new System.Drawing.Point(14, 486);
            this.radioButtonNotify.Name = "radioButtonNotify";
            this.radioButtonNotify.Size = new System.Drawing.Size(355, 25);
            this.radioButtonNotify.TabIndex = 15;
            this.radioButtonNotify.TabStop = true;
            this.radioButtonNotify.Text = "I want to be notified if a new paper is published";
            this.radioButtonNotify.UseVisualStyleBackColor = true;
            this.radioButtonNotify.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkedListAreas
            // 
            this.checkedListAreas.FormattingEnabled = true;
            this.checkedListAreas.Location = new System.Drawing.Point(145, 294);
            this.checkedListAreas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListAreas.Name = "checkedListAreas";
            this.checkedListAreas.Size = new System.Drawing.Size(259, 154);
            this.checkedListAreas.TabIndex = 16;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 541);
            this.Controls.Add(this.checkedListAreas);
            this.Controls.Add(this.radioButtonNotify);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton radioButtonNotify;
        private System.Windows.Forms.CheckedListBox checkedListAreas;
    }
}