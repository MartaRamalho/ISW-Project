﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;

namespace MagazineGUI
{
    public partial class Register : MagazineISWFormBase
    {
        private string id, name, surname, email, username, password, fieldsOfInterest;

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private bool notify;
        public Register(IMagazineISWService service):base(service)
        {
            InitializeComponent();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            id = textBoxID.Text;
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            email = textBoxEmail.Text;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            if (fieldsOfInterest == null) { fieldsOfInterest = "none"; }
            else { fieldsOfInterest = textBoxFields.Text; }
            notify = checkBoxNotify.Checked;
            try
            {
                service.RegisterUser(id, name, surname, notify, fieldsOfInterest, email, username, password);
                MessageBox.Show("User Registered correctly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } 
            catch (ServiceException ex) 
            {
                if(ex.Message=="Invalid Id")
                {
                    MessageBox.Show("There was an internal error, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
