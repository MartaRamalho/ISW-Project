using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace MagazineGUI
{
    public partial class SubmitPaper : MagazineISWFormBase
    {
        int idArea;
        string title;
        List<ComboBox> comboList;
        public SubmitPaper(IMagazineISWService service):base(service)
        {
            InitializeComponent();
            LoadDataArea();
            LoadDataPeople();
        }

        private void LoadDataArea()
        {
            Dictionary<int, string> areas = new Dictionary<int, string>();
            ICollection<int> list = service.ListAllAreas();
            comboBoxArea.Items.Clear();
            if(areas != null)
                foreach(int area in list)
                {
                    areas.Add(area, service.GetAreaName(area));
                }
            comboBoxArea.DataSource = new BindingSource(areas, null);
            
            comboBoxArea.DisplayMember = "Value";
            comboBoxArea.ValueMember = "Key";
            comboBoxArea.SelectedIndex = -1;
            comboBoxArea.ResetText();
        }

        private void LoadDataPeople()
        {
            try
            {
                comboList = new List<ComboBox>();
                Dictionary<string, string> persons = new Dictionary<string, string>();
                List<string> list = service.GetListPeople();
                List<string> people = new List<string>(list);
                people.Remove(service.GetCurrentUserId());
                foreach(string person in people)
                {
                    persons.Add(person, service.GetFullName(person)+" - "+person);
                }
                LoadComboBox(comboBoxAuthor1, persons);
                LoadComboBox(comboBoxAuthor2, persons);
                LoadComboBox(comboBoxAuthor3, persons);
                LoadComboBox(comboBoxAuthor4, persons);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox(ComboBox comboBox, Dictionary<string, string> people)
        {
            comboBox.DataSource = new BindingSource(people, null);
            
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.SelectedIndex = -1;
            comboList.Add(comboBox);
        }

        public void refreshList(ComboBox comboBox, Dictionary<string, string> people)
        {
            object selected = comboBox.SelectedItem;
            comboBox.DataSource = new BindingSource(people, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            if (selected != null)
                comboBox.SelectedItem = selected;
            else
                comboBox.SelectedIndex = -1;
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            title = textBoxTitle.Text;
            try
            {
                if (comboBoxArea.SelectedValue == null) idArea = -1;
                else idArea = (int)comboBoxArea.SelectedValue;
                int id = service.SubmitPaper(idArea, title, DateTime.Today);
                foreach(ComboBox comboBox in comboList)
                {
                    if (comboBox.SelectedItem != null)
                    {
                        string personId = comboBox.SelectedValue.ToString();
                        service.AddCoAuthors(personId, id);
                    }
                }
                MessageBox.Show("Paper Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void OnFocusingForm(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> persons = new Dictionary<string, string>();
                List<string> list = service.GetListPeople();
                List<string> people = new List<string>(list);
                people.Remove(service.GetCurrentUserId());
                foreach (string person in people)
                {
                    persons.Add(person, service.GetFullName(person) + " - " + person);
                }
                refreshList(comboBoxAuthor1, persons);
                refreshList(comboBoxAuthor2, persons);
                refreshList(comboBoxAuthor3, persons);
                refreshList(comboBoxAuthor4, persons);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton4Clicked(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxAuthor4);
        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxAuthor3);
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxAuthor2);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearComboBox(comboBoxAuthor1);
        }

        private void ClearComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            comboBox.ResetText();
        }

        private void comboBoxAuthor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAuthor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAuthor3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxAuthor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
