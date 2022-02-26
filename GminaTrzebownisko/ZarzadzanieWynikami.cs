using System;
using System.Collections.Generic;
using System.Text;

namespace GminaTrzebownisko
{
    public class ZarzadzanieWynikami : IZarzadzanieWynikami
    {
        private int wyn=0;
        public int getwynik()
        {
            return wyn;
        }

        public void setwynik(int wyn)
        {
            this.wyn = wyn;
        }
        public void zwieksz()
        {
            wyn++;
        }
    }
}
