using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEATestTask
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        void AddDocumentManager()
        {
            DocumentManager manager = new DocumentManager();
            manager.MdiParent = this;
            manager.View = new TabbedView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void GetProfileData()
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmProfileList fcp = new FrmProfileList();

            if (Application.OpenForms.OfType<FrmProfileList>().Any())
            {

                Application.OpenForms["FrmProfileList"].BringToFront();
            }
            else
            {
                fcp.MdiParent = this;
                fcp.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmAddNewRecord().ShowDialog();
        }
    }
}
