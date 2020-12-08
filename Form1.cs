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
using System.Windows.Controls;


namespace Database_Tesing
{

    public partial class Form1 : Form
    {
        int cLeft = 2;
        int number = 1;
        List<string> txtBoxName = new List<string>();
        int countTxtBox = 1;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void newTextboxBtn_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox myTB = AddNewTextBox();
            comboBox1.Items.Add(myTB.Name);
            comboBox2.Items.Add(myTB.Name);
            comboBox3.Items.Add(myTB.Name);
            comboBox4.Items.Add(myTB.Name);
            comboBox5.Items.Add(myTB.Name);
            comboBox6.Items.Add(myTB.Name);
            comboBox7.Items.Add(myTB.Name);
            countTxtBox++;
        }
        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            txt.Name = "myTxtBox" + countTxtBox;
            this.Controls.Add(txt);
            txt.Top = cLeft * 35;
            txt.Left = 150;
            txt.Text = "Textbox " + this.number.ToString();
            cLeft = cLeft + 1;
            number = number + 1;
            return txt;
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            Control ctrl1 = Controls["myTxtBox" + comboBox1.SelectedIndex];
            Control ctrl2 = Controls["myTxtBox" + comboBox2.SelectedIndex];
            Control ctrl3 = Controls["myTxtBox" + comboBox3.SelectedIndex];
            Control ctrl4 = Controls["myTxtBox" + comboBox4.SelectedIndex];
            Control ctrl5 = Controls["myTxtBox" + comboBox5.SelectedIndex];
            Control ctrl6 = Controls["myTxtBox" + comboBox6.SelectedIndex];
            Control ctrl7 = Controls["myTxtBox" + comboBox7.SelectedIndex];
            MessageBox.Show(ctrl1.Text + ctrl2.Text + ctrl3.Text + ctrl4.Text + ctrl5.Text + ctrl6.Text + ctrl7.Text);

            DbConnection dbConn = new DbConnection();
            dbConn.connect();
            Admin textbox = new Admin();

            textbox.Textbox1 = ctrl1.Text;
            textbox.Textbox2 = ctrl2.Text;
            textbox.Textbox3 = ctrl3.Text;
            textbox.Textbox4 = ctrl4.Text;
            textbox.Textbox5 = ctrl5.Text;
            textbox.Textbox6 = ctrl6.Text;
            textbox.Textbox7 = ctrl7.Text;

            Textbox1Handler newTxtbox1 = new Textbox1Handler();
            int recordCnt = newTxtbox1.addTextbox1(dbConn.getConn(), textbox);
            MessageBox.Show(recordCnt + " new details has been inserted !!");


        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Edit edtForm = new Edit();
            edtForm.Show();
        }
    }
}
