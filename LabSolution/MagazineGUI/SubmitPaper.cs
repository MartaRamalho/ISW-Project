using Magazine.Entities;
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
    public partial class SubmitPaper : MagazineISWFormBase
    {
        int idArea;
        string title;
        public SubmitPaper(IMagazineISWService service):base(service)
        {
            InitializeComponent();
            LoadDataArea();
            LoadDataPeople();
        }

        public void LoadDataArea()
        {
            ICollection<string> areas = service.ListAllAreas();
            comboBoxArea.Items.Clear();
            if(areas != null)
                foreach(string area in areas)
                {
                    comboBoxArea.Items.Add(area);
                }
            comboBoxArea.SelectedIndex = -1;
            comboBoxArea.ResetText();
        }

        public void LoadDataPeople()
        {
            List<string> people = service.GetListPeople();
            comboBoxAuthor1.Items.Clear();
            comboBoxAuthor2.Items.Clear();
            comboBoxAuthor3.Items.Clear();
            comboBoxAuthor4.Items.Clear();
            if(people != null)
                foreach(String id in people)
                {
                    comboBoxAuthor1.Items.Add(id);
                    comboBoxAuthor2.Items.Add(id);
                    comboBoxAuthor3.Items.Add(id);
                    comboBoxAuthor4.Items.Add(id);
                }
            comboBoxAuthor1.SelectedIndex = -1;
            comboBoxAuthor2.SelectedIndex = -1;
            comboBoxAuthor3.SelectedIndex = -1;
            comboBoxAuthor4.SelectedIndex = -1;
            comboBoxAuthor1.ResetText();
            comboBoxAuthor2.ResetText();
            comboBoxAuthor3.ResetText();
            comboBoxAuthor4.ResetText();
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            idArea = service.GetAreaIdByName(comboBoxArea.SelectedText);
            title = textBoxTitle.Text;
            try
            {
                int id = service.SubmitPaper(idArea, title, DateTime.Today);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            RegisterPerson register = new RegisterPerson(service);
            register.ShowDialog();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitPaper_Load(object sender, EventArgs e)
        {

        }

        private void changeSelectionA1(object sender, EventArgs e)
        {
            textBoxA1.Text = service.GetFullName(comboBoxAuthor1.SelectedText);
        }

        private void changeSelectionA2(object sender, EventArgs e)
        {
            textBoxA2.Text = service.GetFullName(comboBoxAuthor2.SelectedText);
        }

        private void ChangeSelectionA3(object sender, EventArgs e)
        {
            textBoxA3.Text = service.GetFullName(comboBoxAuthor3.SelectedText);
        }

        private void ChangeSelectionA4(object sender, EventArgs e)
        {
            textBoxA4.Text = service.GetFullName(comboBoxAuthor4.SelectedText);
        }
    }
}
