using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (!correctURL)
            {
                throw new UserException("FEL: Den angedda URL-adressen är inte korrekt.");
            }
            return correctURL;
        }
        public  bool CheckEmptyTxt(string text)
        {
            bool isEmpty = String.IsNullOrEmpty(text);

            if (isEmpty)
            {
                throw new UserException("FEL: Ett obligatoriskt textfält är inte ifyllt.");
            }
            return isEmpty;
        }
    }
}
