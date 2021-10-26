using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Validation : UserException
    {
        public Validation() { }

        public override bool CheckURL(string url)
        {
            Uri uri;
            bool correctURL = 
            Uri.TryCreate(url, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
            try
            {
                if (!correctURL)
                {
                    throw new UserException("FEL");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Den angedda URL-adressen är inte korrekt.");
            }
            return correctURL;
        }
        public  bool CheckEmptyTxt(string text)
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
