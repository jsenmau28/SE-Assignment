using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Tesing
{
    public partial class Edit : Form
    {
       
        public Edit()
        {
            InitializeComponent();
        }

        public int editData(MySqlConnection conn, Admin admin)
        {
            string updateQuery = "UPDATE dynamictesting1.template SET Textbox1='" + txtbox1.Text + "',Textbox2='" + txtbox2.Text + "',Textbox3='" + txtbox3.Text + "',Textbox4='" + txtbox4.Text + "',Textbox5='" + txtbox5.Text + "',Textbox6='" + txtbox6.Text + "',Textbox7='" + txtbox7.Text + "' WHERE id=" + int.Parse(idTxtbox.Text);


            MySqlCommand sqlComm = new MySqlCommand(updateQuery, conn);
            return sqlComm.ExecuteNonQuery();
            
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin textbox = new Admin();

            textbox.Textbox1 = txtbox1.Text;
            textbox.Textbox2 = txtbox2.Text;
            textbox.Textbox3 = txtbox3.Text;
            textbox.Textbox4 = txtbox4.Text;
            textbox.Textbox5 = txtbox5.Text;
            textbox.Textbox6 = txtbox6.Text;
            textbox.Textbox7 = txtbox7.Text;

            int recordCnt =editData(dbConn.getConn(), textbox);
            MessageBox.Show(recordCnt + " new details has been updated !!");


        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            Visible = false;

        }
    }
}
