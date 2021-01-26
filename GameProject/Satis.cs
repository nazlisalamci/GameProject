using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Satis : ISatis
    {
        public void OyunSatisi(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+ " adlı oyuncuya satış yapıldı");
        }
    }
}
