using MODELS;
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
        private static PodcastController podcontroll = new PodcastController();
        private static CategoryController catontroll = new CategoryController();

        public static bool CheckURL(string url) 
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

        public static bool CheckEmptyTxt(string text)
        {
            bool isEmpty = String.IsNullOrEmpty(text);
            try
            {
                if (isEmpty)
                {
                    throw new UserException("Ett obligatoriskt textfält är inte ifyllt.");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "FEL!");
            }
            return isEmpty;
        }

        public static bool ContainsWhiteSpace(string text)
        {
            bool hasWhiteSpace = text.Any(Char.IsWhiteSpace);
            try
            {
                if (hasWhiteSpace)
                {
                    throw new UserException("Du får inte ha mellanslag i fälten");

                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "FEL!");
            }
            return hasWhiteSpace;
        }

        public static bool isNull(object obj)
        {
            bool isNull = true;
            try
            {
                if (obj == null)
                {
                    throw new UserException("Objektet blev null");
                    isNull = true;
                }
                else
                {
                    isNull = false;
                    return isNull;
                }
            }
            catch (UserException ex)
            {
                
            }
            return isNull;
        }

        public static bool isPodcastNameTaken(string name)
        {
            
            bool isTaken = true;
            try
            {
              Media pod = podcontroll.GetPodByName(name);
                if(pod != null)
                {
                    isTaken = true;
                    throw new UserException("Du har redan en podcast med detta namnet");
                   
                }
                else
                {
                    isTaken = false;
                    return isTaken;
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, "Fel!");
            }
            return isTaken;
        }

       

        public static bool isCategoryNameTaken(string name)
        {
            bool isTaken = true;
            try
            {
                Category cat = catontroll.GetCategoryByName(name);
                if (cat != null)
                {
                    throw new UserException("Du har redan en Kategori med detta namnet");
                    isTaken = true;
                }
                else
                {
                    isTaken = false;
                    return isTaken;
                }
            }
            catch (UserException ex)
            {

                MessageBox.Show(ex.Message, "Fel!");
            }
            return isTaken;
        }
    }
}
