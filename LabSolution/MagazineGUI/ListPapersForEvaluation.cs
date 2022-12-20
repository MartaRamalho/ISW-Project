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
    public partial class ListPapersForEvaluation : MagazineISWFormBase
    {
        public ListPapersForEvaluation(IMagazineISWService service):base(service)
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                
                labelAreaName.Text = service.GetAreaName(service.GetEditorArea());
                ICollection<int> list = service.ListPapersInAreaPendingEvaluation(service.GetEditorArea());
                BindingList<object> bindinglist = new BindingList<object>();
                foreach (int id in list)
                {
                    service.GetPaperById(id, out string title, out DateTime date, out string responsible);
                    bindinglist.Add(new
                    {
                        grid_Id = id,
                        grid_Title = title,
                        grid_Date = date,
                        grid_Author = responsible
                    });
                }
                bindingSource1.DataSource = bindinglist;
                dataGridView1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetSelectedId()
        {
            return (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void ListPapersForEvaluation_Load(object sender, EventArgs e)
        {
            buttonEvaluate.Enabled = false;
            dataGridView1.ClearSelection();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            EvaluatePaper eval = new EvaluatePaper(service, GetSelectedId());
            eval.ShowDialog();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                buttonEvaluate.Enabled = true;
            }
            else
                buttonEvaluate.Enabled = false;
        }

        private void ListPapersForEvaluation_Enter(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView1.ClearSelection();
        }
    }
}
