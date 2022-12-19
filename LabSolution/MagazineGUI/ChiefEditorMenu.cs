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
    public partial class ChiefEditorMenu : Menu
    {
        public ChiefEditorMenu():base()
        {
            InitializeComponent();
        }
        public ChiefEditorMenu(IMagazineISWService service) : base(service)
        {
            InitializeComponent();
        }

        private void ListPapersClicked(object sender, EventArgs e)
        {

        }

        private void BuildIssueClicked(object sender, EventArgs e)
        {

        }
    }
}
