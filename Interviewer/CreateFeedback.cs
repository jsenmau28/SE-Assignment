using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment_InterviewerForm
{
    public class CreateFeedback
    {
        private int interviewerChosenTemplateID;
        private string interviewerFirstName;
        private string interviewerLastName;
        private string interviewerAddress;
        private string interviewerPosition;
        private string interviewerEmail;
        private int interviewerPhoneNo;
        private string interviewerDay;

        public string InterviewerFirstName { get => interviewerFirstName; set => interviewerFirstName = value; }
        public string InterviewerLastName { get => interviewerLastName; set => interviewerLastName = value; }
        public string InterviewerAddress { get => interviewerAddress; set => interviewerAddress = value; }
        public string InterviewerPosition { get => interviewerPosition; set => interviewerPosition = value; }
        public string InterviewerEmail { get => interviewerEmail; set => interviewerEmail = value; }
        public int InterviewerPhoneNo { get => interviewerPhoneNo; set => interviewerPhoneNo = value; }
        public int InterviewerChosenTemplateID { get => interviewerChosenTemplateID; set => interviewerChosenTemplateID = value; }
        public string InterviewerDay { get => interviewerDay; set => interviewerDay = value; }
    }

    public class createFeedback

    {
        public int insertInterviewer(MySqlConnection connect, CreateFeedback sendData)
        {
            string interviewerAddSQL = "INSERT INTO interviewer (templateID ,lastName, firstName, address, position, email, phoneNo) "
                + " VALUES ('"+sendData.InterviewerChosenTemplateID+ "','"+sendData.InterviewerLastName+ "' , '" +sendData.InterviewerFirstName+ 
                "', '" +sendData.InterviewerAddress+ "' , '" +sendData.InterviewerPosition+ 
                "','" +sendData.InterviewerEmail+ "','" +sendData.InterviewerPhoneNo+ "')";
                

            MySqlCommand command = new MySqlCommand(interviewerAddSQL, connect);

            return command.ExecuteNonQuery();

        }
      
    }
}
