using System;
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
        public Register(IMagazineISWService service):base(service)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            try
            {
                service.RegisterUser();
                //confirm
                this.Close();
            } 
            catch (ServiceException e) 
            {
                MessageBox.Show("Username already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
