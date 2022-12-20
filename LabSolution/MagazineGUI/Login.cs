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
        String username, password;
        public Login(IMagazineISWService service) :base(service)
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ClickedCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            username=textBoxUsername.Text;
            password=textBoxPassword.Text;
            try
            {
                service.Login(username, password);
                if (service.IsChiefEditor())
                {
                    ChiefEditorMenu chiefMenu= new ChiefEditorMenu(service);
                    chiefMenu.Show();
                }
                else if (service.IsAreaEditor())
                {
                    AreaEditorMenu areaEditorMenu= new AreaEditorMenu(service);
                    areaEditorMenu.Show();
                }
                else 
                {
                    Menu menu = new Menu(service);
                    menu.Show();
                }
                Application.OpenForms["MagazineApp"].Hide();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
