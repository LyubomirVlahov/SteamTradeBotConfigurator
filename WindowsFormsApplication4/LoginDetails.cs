using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    public class LogginDetails
    {
        private string userName;
        private string password;
        private string displayName;
        private string displayNamePrefix;
        private string chatResponse;

        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string DisplayName { get { return displayName; } set { displayName = value; } }
        public string DisplayNamePrefix { get { return displayNamePrefix; } set { displayNamePrefix = value; } }
        public string ChatResponse { get { return chatResponse; } set { chatResponse = value; } }

        public LogginDetails(string userName, string password, string displayName, string displayNamePrefix, string chatResponse)
        {
            this.userName = userName;
            this.password = password;
            this.displayName = displayName;
            this.displayNamePrefix = displayNamePrefix;
            this.chatResponse = chatResponse;
        }

    }
}
