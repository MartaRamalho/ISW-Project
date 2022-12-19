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
    public partial class RegisterPerson : MagazineISWFormBase
    {
        String name, surname, id;
        public RegisterPerson(IMagazineISWService service):base(service)
        {
            InitializeComponent();
        }

        private void cancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            id = GenerateId();
            try
            {
                service.RegisterPerson(id, name, surname);
            }
            catch(Exception ex)
            {
                if (ex.Message == "Invalid Id")
                {
                    MessageBox.Show("There was an internal error, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GenerateId()
        {
            int num = new Random().Next(10000000, 99999999);
            char letter = (char)('A' + new Random().Next(0, 26));
            string DNI = num.ToString() + letter.ToString();
            return DNI;
        }
    }
}
