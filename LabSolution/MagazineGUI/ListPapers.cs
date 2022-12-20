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
    public partial class ListPapers : MagazineISWFormBase
    {
        public ListPapers(IMagazineISWService service) : base(service)
        {
            InitializeComponent();
            LoadData();
            ICollection<int> paperIds = service.ListAllPapers();
            LoadTable(paperIds);
        }

        public void LoadData()
        {
            ICollection<int> issuesId = service.ListAllIssues();
            comboBoxIssue.Items.Clear();
            if (issuesId != null)
                foreach (int id in issuesId)
                    comboBoxIssue.Items.Add(id);
            comboBoxIssue.SelectedIndex = -1;
            comboBoxIssue.ResetText();
            issuesBindingSource.DataSource = null;
        }

        private void List_Papers_Load(object sender, EventArgs e)
        {

        }

        private void LoadTable(ICollection<int> paperIds)
        {
            try
            {
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (int idPaper in paperIds)
                {
                    service.GetPaperById(idPaper, out string title, out DateTime date, out string responsible);
                    string names = "";
                    foreach (string idPerson in service.ListAllAuthors(idPaper))
                    {
                        names += service.GetFullName(idPerson) + "; ";
                    }
                    bindinglist.Add(new
                    {
                        grid_Title = title,
                        grid_Authors = names,
                        grid_State = GetState(idPaper),
                    });
                }
                issuesBindingSource.DataSource = bindinglist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (comboBoxIssue.SelectedIndex == -1)
                    id = -1;
                else
                    id = (int)comboBoxIssue.SelectedItem;
                ICollection<int> paperIds;
                if (id == -1)
                    paperIds = service.ListAllPapers();
                else
                    paperIds = service.ListAllPapersByIssue(id);
                LoadTable(paperIds);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetState(int paperId)
        {
            try
            {
                if (service.isEvaluationPending(paperId))
                {
                    return "Pending Evaluation";
                }
                else if (service.isPublicationPending(paperId))
                {
                    return "Pending Publication";
                }
                else if (service.isPublishedPaper(paperId))
                {
                    return "Is Published";
                }
                return "Is Rejected";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if(comboBoxIssue.SelectedIndex != -1)
            {
                comboBoxIssue.SelectedIndex = -1;
            }
        }
    }
}
