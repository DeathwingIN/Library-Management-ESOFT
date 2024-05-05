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

namespace LIB_Original
{
    public partial class BookList : Form
    {
        //Define Variables 
        string bkname;
        string bkid;
        Int64 rowid;


        public BookList()
        {
            InitializeComponent();
            datagridview();
        }

        
        //DataGrid View 
        private void datagridview()
        {
            //Build Sql Connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(local); database=LIB Managemnt;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //All Active Book List
            cmd.CommandText = "select * FROM [LIB Managemnt].[dbo].[Catalog_Table] where Is_Active = 1 ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            //SQL Data to Data Grid View 
            if (DS.Tables[0].Rows.Count != 0)
            {
                gdr_Borrowings.DataSource = DS.Tables[0];
            }
        }


        //Data Change According to Selection 
        private void gdr_Borrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdr_Borrowings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(gdr_Borrowings.Rows[e.RowIndex].Cells[0].Value.ToString());
                bkname = gdr_Borrowings.Rows[e.RowIndex].Cells[1].Value.ToString();
                bkid= gdr_Borrowings.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            txt_BookName.Text = bkname;
            txt_BookID.Text = bkid;
        }
    }
}
