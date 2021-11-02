using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    
    public class UserException : Exception
    {
        public string Header { get; set; }
        public UserException(string text) : base(text)
        {
        }

        public UserException(string msg, string header) : base(msg)
        {
            this.Header = header;
        }

        public UserException()
        { 
        }

    }
}
