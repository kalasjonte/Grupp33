using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Egen exceptionklass, ärver från Exception

namespace BLL
{
    public class UserException : Exception
    {
        public UserException(string text) : base(text)
        {
        }
        public UserException()
        { 
        }

        public virtual bool CheckURL(string urlAdress) //virtual för att kunna override:a i Validation
        {
            Uri uri;
            bool correctURL = false;
            if (!correctURL)
            {
                throw new UserException("FEL");
            }
            return correctURL;
        }

    }
}
