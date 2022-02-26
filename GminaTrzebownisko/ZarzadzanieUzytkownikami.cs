using System;
using System.Collections.Generic;
using System.Text;

namespace GminaTrzebownisko
{
    public class ZarzadzanieUzytkownikami : IZarzadzanieUzytkownikami
    {
        private string name; 
        public string getname()
        {
            return name;
        }

        public void setname(string name)
        {
           this.name = name;
        }
    }
}
