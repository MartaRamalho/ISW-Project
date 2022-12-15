using Magazine.Services;
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
    public partial class MagazineApp : Form
    {
        IMagazineISWService service;
        public MagazineApp(IMagazineISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClickedLogin(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void ClickedRegister(object sender, EventArgs e)
        {
            Register register = new Register(service);
            register.ShowDialog();
        }
    }
}
