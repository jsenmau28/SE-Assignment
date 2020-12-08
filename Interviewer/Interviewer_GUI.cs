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

using System.IO;

namespace Assignment_InterviewerForm
{
    public partial class Form1 : Form
    {
        private Button sendFeedbackbtn;
        private Button templateLoadButton;
        private DataGridView templateDataGrid;
        private Label label8;
        private TextBox txt7;
        private Button searchIDButton;
        private Label IDTemplateLabel;
        private TextBox idSearch;
        private TextBox txt4;
        private Button button2;
        private TextBox txt6;
        private TextBox txt5;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection db_connect = new DBConnection();
            db_connect.tryConn();

            CreateFeedback sendInterviewer = new CreateFeedback();
            sendInterviewer.InterviewerChosenTemplateID = int.Parse(idSearch.Text);
            sendInterviewer.InterviewerLastName = txt1.Text;
            sendInterviewer.InterviewerFirstName = txt2.Text;
            sendInterviewer.InterviewerAddress = txt3.Text;
            sendInterviewer.InterviewerPosition = txt4.Text;
            sendInterviewer.InterviewerPhoneNo = int.Parse(txt5.Text);
            sendInterviewer.InterviewerEmail = txt6.Text;
            sendInterviewer.InterviewerDay = txt7.Text;

            createFeedback toDB = new createFeedback();
            int recordCount = toDB.insertInterviewer(db_connect.getConnect(), sendInterviewer);
            MessageBox.Show("Feedback has been created. Check Database to view it.");


        }
        private void searchIDButton_Click(object sender, EventArgs e)
        {

        }

        private void templateLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.sendFeedbackbtn = new System.Windows.Forms.Button();
            this.templateLoadButton = new System.Windows.Forms.Button();
            this.templateDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.IDTemplateLabel = new System.Windows.Forms.Label();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.templateDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sendFeedbackbtn
            // 
            this.sendFeedbackbtn.Location = new System.Drawing.Point(569, 438);
            this.sendFeedbackbtn.Name = "sendFeedbackbtn";
            this.sendFeedbackbtn.Size = new System.Drawing.Size(126, 40);
            this.sendFeedbackbtn.TabIndex = 46;
            this.sendFeedbackbtn.Text = "Send The Feedback!";
            this.sendFeedbackbtn.UseVisualStyleBackColor = true;
            // 
            // templateLoadButton
            // 
            this.templateLoadButton.Location = new System.Drawing.Point(12, 416);
            this.templateLoadButton.Name = "templateLoadButton";
            this.templateLoadButton.Size = new System.Drawing.Size(126, 39);
            this.templateLoadButton.TabIndex = 45;
            this.templateLoadButton.Text = "Load Templates";
            this.templateLoadButton.UseVisualStyleBackColor = true;
            // 
            // templateDataGrid
            // 
            this.templateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.templateDataGrid.Location = new System.Drawing.Point(12, 131);
            this.templateDataGrid.Name = "templateDataGrid";
            this.templateDataGrid.Size = new System.Drawing.Size(391, 279);
            this.templateDataGrid.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label8.Location = new System.Drawing.Point(409, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "(Placeholder)";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(530, 392);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(163, 20);
            this.txt7.TabIndex = 42;
            // 
            // searchIDButton
            // 
            this.searchIDButton.Location = new System.Drawing.Point(202, 102);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(75, 23);
            this.searchIDButton.TabIndex = 41;
            this.searchIDButton.Text = "Search";
            this.searchIDButton.UseVisualStyleBackColor = true;
            // 
            // IDTemplateLabel
            // 
            this.IDTemplateLabel.AutoSize = true;
            this.IDTemplateLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.IDTemplateLabel.Location = new System.Drawing.Point(8, 82);
            this.IDTemplateLabel.Name = "IDTemplateLabel";
            this.IDTemplateLabel.Size = new System.Drawing.Size(97, 19);
            this.IDTemplateLabel.TabIndex = 40;
            this.IDTemplateLabel.Text = "Template ID:";
            // 
            // idSearch
            // 
            this.idSearch.Location = new System.Drawing.Point(12, 104);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(166, 20);
            this.idSearch.TabIndex = 39;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(529, 312);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(164, 20);
            this.txt4.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "Create The Feedback";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(530, 365);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(163, 20);
            this.txt6.TabIndex = 36;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(530, 338);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(165, 20);
            this.txt5.TabIndex = 35;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(529, 284);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(165, 20);
            this.txt3.TabIndex = 34;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(530, 256);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(165, 20);
            this.txt2.TabIndex = 33;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(530, 225);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(165, 20);
            this.txt1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label7.Location = new System.Drawing.Point(409, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "(Placeholder)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label6.Location = new System.Drawing.Point(409, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "(Placeholder)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label5.Location = new System.Drawing.Point(409, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "(Placeholder)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label4.Location = new System.Drawing.Point(409, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "(Placeholder)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label3.Location = new System.Drawing.Point(409, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "(Placeholder)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label2.Location = new System.Drawing.Point(409, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "(Placeholder)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Please Fill In The Form Below.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(709, 489);
            this.Controls.Add(this.sendFeedbackbtn);
            this.Controls.Add(this.templateLoadButton);
            this.Controls.Add(this.templateDataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.searchIDButton);
            this.Controls.Add(this.IDTemplateLabel);
            this.Controls.Add(this.idSearch);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.templateDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}