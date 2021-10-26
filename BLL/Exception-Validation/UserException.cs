using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    //Egen exceptionklass, ärver från Exception
    public class UserException : Exception
    {
        public UserException(string text) : base(text)
        {
        }
        public UserException()
        { 
        }

        //virtual för att kunna override:a i Validation, vi kan behöva kolla olika url:er i framtiden
        public virtual bool CheckURL(string urlAdress) 
        {
            bool correctURL = false;
            return correctURL;
        }

    }
}
