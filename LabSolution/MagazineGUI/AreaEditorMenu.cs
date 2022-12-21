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
    public partial class AreaEditorMenu : Menu
    {
        public AreaEditorMenu() : base()
        {
            InitializeComponent();
        }
        public AreaEditorMenu(IMagazineISWService service):base(service)
        {
            InitializeComponent();
        }

        private void EvaluatePaperClicked(object sender, EventArgs e)
        {
            ListPapersForEvaluation listP = new ListPapersForEvaluation(service);
            listP.ShowDialog();
        }
    }
}
