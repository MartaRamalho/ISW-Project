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
    public partial class BuildIssue : MagazineISWFormBase
    {
        public BuildIssue(IMagazineISWService service):base(service)
        {
            InitializeComponent();
            LoadDataArea();
            buttonPublish.Enabled = false;
            buttonUnpublish.Enabled = false;
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBoxArea.SelectedValue;
                ICollection<int> paperIds = service.ListPapersInAreaPendingEvaluation(id);
                LoadTable(bindingSourcePending, paperIds);
                ICollection<int> paperIdsPublished = service.PublishedPapers(id);
                LoadTable(bindingSourcePublished, paperIdsPublished);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTable(BindingSource bindingS, ICollection<int> papers)
        {
            try
            {
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (int idPaper in papers)
                {
                    service.GetPaperById(idPaper, out string title, out DateTime date, out string responsible);
                    bindinglist.Add(new
                    {
                        grid_Title = title,
                        grid_Id = idPaper
                    });
                }
                bindingS.DataSource = bindinglist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataArea()
        {
            labelNumber.Text = ""+service.BuildIssue();
            Dictionary<int, string> areas = new Dictionary<int, string>();
            ICollection<int> list = service.ListAllAreas();
            comboBoxArea.Items.Clear();
            if (areas != null)
                foreach (int area in list)
                {
                    areas.Add(area, service.GetAreaName(area));
                }
            comboBoxArea.DataSource = new BindingSource(areas, null);

            comboBoxArea.DisplayMember = "Value";
            comboBoxArea.ValueMember = "Key";
            comboBoxArea.SelectedIndex = 0;
            comboBoxArea.ResetText();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUnpublish_Click(object sender, EventArgs e)
        {

        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPending_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridPublished_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
