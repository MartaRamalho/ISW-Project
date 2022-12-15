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
    public partial class Login : MagazineISWFormBase
    {
        public Login(IMagazineISWService service) :base(service)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void ClickedCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            
        }
    }
}
