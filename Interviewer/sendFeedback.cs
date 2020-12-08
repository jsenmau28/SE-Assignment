using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_InterviewerForm
{
    class sendFeedback
    {
        private string sendLastNameFeedback;
        private string sendFirstNameFeedback;
        private string sendAddressFeedback;
        private string sendPhoneNoFeedback;
        private string feedbackcontent;

        public string SendLastNameFeedback { get => sendLastNameFeedback; set => sendLastNameFeedback = value; }
        public string SendFirstNameFeedback { get => sendFirstNameFeedback; set => sendFirstNameFeedback = value; }
        public string SendAddressFeedback { get => sendAddressFeedback; set => sendAddressFeedback = value; }
        public string SendPhoneNoFeedback { get => sendPhoneNoFeedback; set => sendPhoneNoFeedback = value; }
        public string Feedbackcontent { get => feedbackcontent; set => feedbackcontent = value; }
    }
}
