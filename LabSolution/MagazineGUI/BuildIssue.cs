using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class BuildIssue : MagazineISWFormBase
    {
        int issueNum;
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
                if (comboBoxArea.SelectedIndex != -1)
                {
                    int id = service.GetAreaIdByName(comboBoxArea.SelectedItem.ToString());
                    ICollection<int> paperIds = service.ListPapersInAreaPendingPublication(id);
                    LoadTable(bindingSourcePending, paperIds);
                    ICollection<int> paperIdsPublished = service.PublishedPapers(id, issueNum);
                    LoadTable(bindingSourcePublished, paperIdsPublished);
                }
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
            try
            {
                issueNum=service.BuildIssue();
                labelNumber.Text = "" + issueNum;
                ICollection<int> areas = service.ListAllAreas();
                comboBoxArea.Items.Clear();
                if (areas != null)
                    foreach (int area in areas)
                    {
                        comboBoxArea.Items.Add(service.GetAreaName(area));
                    }
                comboBoxArea.SelectedIndex = -1;
                comboBoxArea.ResetText();
                comboBoxArea.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUnpublish_Click(object sender, EventArgs e)
        {
            int idPaper = (int)dataGridPublished.SelectedRows[0].Cells[0].Value;
            try
            {
                service.UnPublishPaper(idPaper);
                int id = service.GetAreaIdByName(comboBoxArea.SelectedItem.ToString());
                ICollection<int> paperIds = service.ListPapersInAreaPendingPublication(id);
                LoadTable(bindingSourcePending, paperIds);
                ICollection<int> paperIdsPublished = service.PublishedPapers(id, issueNum);
                LoadTable(bindingSourcePublished, paperIdsPublished);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            int idPaper = (int)dataGridPending.SelectedRows[0].Cells[0].Value;
            try
            {
                service.PublishPaper(idPaper);
                int id = service.GetAreaIdByName(comboBoxArea.SelectedItem.ToString());
                ICollection<int> paperIds = service.ListPapersInAreaPendingPublication(id);
                LoadTable(bindingSourcePending, paperIds);
                ICollection<int> paperIdsPublished = service.PublishedPapers(id, issueNum);
                LoadTable(bindingSourcePublished, paperIdsPublished);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker.Value;
                service.SaveIssue(issueNum, date);
                MessageBox.Show("Issue successfully built.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridPending_SelectionChanged(object sender, EventArgs e)
        {
            
                
        }

        private void dataGridPublished_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPending_Enter(object sender, EventArgs e)
        {
            if (dataGridPending.SelectedRows.Count == 1)
            {
                buttonUnpublish.Enabled = false;
                buttonPublish.Enabled = true;
            }
            else
            {
                buttonUnpublish.Enabled = false;
                buttonPublish.Enabled = false;
            }
        }

        private void dataGridPublished_Enter(object sender, EventArgs e)
        {
            if (dataGridPublished.SelectedRows.Count == 1)
            {
                buttonUnpublish.Enabled = true;
                buttonPublish.Enabled = false;
            }
            else
            {
                buttonUnpublish.Enabled = false;
                buttonPublish.Enabled = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
