using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class UserException : Exception
    {
        public UserException(string text) : base(text)
        {
        }
        
        public virtual bool SomethingThatShouldBeInt32(string intString)
        {
            bool correct = Int32.TryParse(intString, out int result);
            if (!correct)
            {
                throw new UserException("");
            }
            return correct;
        }


    }
}
