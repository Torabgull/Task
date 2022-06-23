using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace ETEATestTask
{
    public partial class FrmAddNewRecord : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAddNewRecord()
        {
            InitializeComponent();
        }
        public static byte[] ImageToByteArray(Image imagin,string extension)
        {
            MemoryStream ms=new MemoryStream();
            imagin.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public Byte[] picture=null;
        private void btnsubmit_Click(object sender, EventArgs e)
        {
          
            if (txtnic.Text.Trim().ToString() == "")
            {
                MessageBox.Show("CNIC is empty...!");
                return;
            }
            if ( txtname.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Name is empty...!");
                return;
            }

            if( txtfname.Text.Trim().ToString()=="")
            {
                MessageBox.Show("Father Name is empty...!");
                return;
            }
            if (pictureEdit1.Image == null)
            {
                MessageBox.Show("Please, upload image...!");
                return;
            }
            if (txtdate.EditValue == null)
            {
                MessageBox.Show("DOB is empty...!");
                return;
            }
            picture = ImageToByteArray(pictureEdit1.Image, ".jpg");
            using (SqlConnection con=ConMgr.GetConnection())
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try 
	            {	        
		 using (SqlTransaction trans=con.BeginTransaction())
                {
                    using (SqlCommand cmd=new SqlCommand("insert into Profile (name,fathername,cnic,dob,picture) Values ('"+txtfname.Text+"','"+txtfname.Text+"','"+txtnic.Text+"','"+Convert.ToDateTime(txtdate.EditValue.ToString()).ToString("yyyy/MM/dd")+"',@picture)",con))
                    {
                        cmd.Transaction=trans;
                        cmd.Parameters.AddWithValue("@picture",(picture==null)? (Object)DBNull.Value: picture).SqlDbType = SqlDbType.VarBinary;
                   cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    txtnic.Text = "";
                    txtname.Text = "";
                    txtfname.Text = "";
                    txtdate.Text = "";
                    pictureEdit1.Image = null;

                    MessageBox.Show("Data Saved...!");
                }
	            }
	            catch (Exception)
	            {
	
		            //throw;
	            }
                con.Close();
            }
            
            
        }
    }
}
