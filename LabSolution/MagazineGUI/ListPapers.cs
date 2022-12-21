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
        public ListPapers(IMagazineISWService service):base(service)
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                ICollection<int> list = service.ListPapersInArea();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
