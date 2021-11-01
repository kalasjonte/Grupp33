using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Podcast : Media
    {

        //SKA BORT SEN E BARA FÖR ATT TESTA
        public Podcast(string name, string url, string type, int freq, Category cate) :base(name, url, type, freq, cate)
        {
            
        }

        public Podcast() 
        { 
        } 


        public override string DisplayInfo()
        {
            return "Det här är en pocast med förljande info:\n" + base.DisplayInfo();
        }
    }
}

