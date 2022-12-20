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
    public partial class EvaluatePaper : MagazineISWFormBase
    {
        string comments;
        bool accepted;
        int paperId;
        public EvaluatePaper(IMagazineISWService service, int idPaper):base(service)
        {
            InitializeComponent();
            this.paperId = idPaper;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool GetEvaluation()
        {
            if (radioButtonAccept.Checked) return true;
            else return false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                comments = textBoxComments.Text;
                accepted = GetEvaluation();
                service.EvaluatePaper(accepted, comments, DateTime.Today, paperId);
                MessageBox.Show("Paper Evaluated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ListPapersForEvaluation form = (ListPapersForEvaluation)Application.OpenForms["ListPapersForEvaluation"];
                form.LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
