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


namespace MagazineGUI
{
    public partial class MagazineApp : MagazineISWFormBase
    {
        public MagazineApp(IMagazineISWService service):base(service)
        {
            InitializeComponent();
        }

        private void ClickedLogin(object sender, EventArgs e)
        {
            Login login = new Login(service);
            login.ShowDialog();
            
        }

        private void ClickedRegister(object sender, EventArgs e)
        {
            Register register = new Register(service);
            register.ShowDialog();
        }

        private void MagazineApp_Load(object sender, EventArgs e)
        {

        }

        private void Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
