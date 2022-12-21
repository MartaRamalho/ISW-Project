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
    public partial class Menu : MagazineISWFormBase
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(IMagazineISWService service) :base(service)
        {
            InitializeComponent();
        }
  
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void LogoutClicked(object sender, EventArgs e)
        {
            try
            {
                service.Logout();
                this.Close();
                Application.OpenForms["MagazineApp"].Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExitClicked(object sender, EventArgs e)
        {
            try
            {
                service.Logout();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SubmitPaperClicked(object sender, EventArgs e)
        {
            SubmitPaper submitPaper = new SubmitPaper(service);
            submitPaper.ShowDialog();
        }

        private void OnMenuClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
