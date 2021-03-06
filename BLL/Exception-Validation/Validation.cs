using MODELS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public static class Validation
    {
        private static MediaController podcontroll = new MediaController();
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
                    throw new UserException("Den angedda URL-adressen är inte korrekt.", "Fel");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, ex.Header);
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
                    throw new UserException("Ett obligatoriskt textfält är inte ifyllt.", "Kolla igenom fälten");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, ex.Header);
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
                    throw new UserException("Du får inte ha mellanslag i fälten", "Kolla igenom fälten");

                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message, ex.Header);
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
                    isNull = true;
                    throw new UserException("Objektet skapades inte");
                    
                }
                else
                {
                    isNull = false;
                    return isNull;
                }
            }
            catch (UserException ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
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
                    isTaken = true;
                    throw new UserException("Du har redan en Kategori med detta namnet");
                    
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

        public static bool ItemsContainsAny(Media podcast)
        {
            bool itemHasAny = false;
            try
            {
                if (!podcast.items.Any())
                {
                    throw new UserException("Podden har felskriven eller ingen item summary / titel. Kunde ej prenumerera");
                }
                else
                {
                    itemHasAny = true;
                    return itemHasAny;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel!");
            }
            return itemHasAny;
        }
    }
}
