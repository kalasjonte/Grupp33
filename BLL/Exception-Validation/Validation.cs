using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public static class Validation 
    {
        private static UserException exception = new UserException();

        public static bool CheckURL(string url) //lägg till så mellanslag etc inte är OK -- ny metod
        {
            Uri uri;
            bool correctURL = 
            Uri.TryCreate(url, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
            try
            {
                if (!correctURL)
                {
                    throw new UserException("Den angedda URL-adressen är inte korrekt.");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "FEL!");
            }
            return correctURL;
        }
        public static  bool CheckEmptyTxt(string text)
        {
            bool isEmpty = String.IsNullOrEmpty(text);
            try
            {
                if (isEmpty)
                {
                    throw new UserException("FEL");
                }
            }
            catch(UserException ex)
            {
                MessageBox.Show(ex.Message, "Ett obligatoriskt textfält är inte ifyllt.");
            }
            return isEmpty;
        }
    }
}
