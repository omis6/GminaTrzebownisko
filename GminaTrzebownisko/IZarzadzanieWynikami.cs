using System;
using System.Collections.Generic;
using System.Text;

namespace GminaTrzebownisko
{
    public interface IZarzadzanieWynikami
    {
        int getwynik();
        void setwynik(int wyn);
        void zwieksz();
    }
}
