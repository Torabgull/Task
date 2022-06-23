using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEATestTask
{
    public partial class FrmProfileList : Form
    {
        public FrmProfileList()
        {
            InitializeComponent();
        }

        private void FrmProfileList_Load(object sender, EventArgs e)
        {
            GetProfileData();
        }
        public void GetProfileData()
        {
            SqlConnection con = ConMgr.GetConnection();
            using (SqlCommand cmd=new SqlCommand("select *from Profile"))
            {
                using (SqlDataAdapter da=new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    da.SelectCommand = cmd;
                    using (DataTable dt=new DataTable())
                    {
                        da.Fill(dt);
                        gridControl1.DataSource = dt;
                    }
                }
                
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmAddNewRecord().ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                    int[] selectedRows = gridView1.GetSelectedRows();  
                    foreach (int rowHandle in selectedRows)  
                    {
                        if (rowHandle >= 0)
                        {
                            var cellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                                ProfileList pf = new ProfileList();
                                pf.Parameters["ID"].Value = cellValue;
                                pf.Parameters["ID"].Visible = false;
                                ReportPrintTool report = new ReportPrintTool(pf);
            
                                report.ShowRibbonPreview();
                        }
                    } 


            //int[] SelectedRowHandles = gridView1.GetSelectedRows();

            //string B = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);  



            //XtraReport1 report = new XtraReport1();
            //report.Parameters["yourParameter1"].Value = firstValue;
            //report.Parameters["yourParameter2"].Value = secondValue;

           


        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AllProfileList pf = new AllProfileList();
            ReportPrintTool report = new ReportPrintTool(pf);

            report.ShowRibbonPreview();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int rowHandle in selectedRows)
            {
                if (rowHandle >= 0)
                {
                    var cellValue = gridView1.GetRowCellValue(rowHandle, gridView1.Columns[0]);
                    ProfileList pf = new ProfileList();
                    pf.Parameters["ID"].Value = cellValue;
                    pf.Parameters["ID"].Visible = false;
                    ReportPrintTool report = new ReportPrintTool(pf);

                    report.ShowRibbonPreview();
                }
            } 

        }
    }
}
