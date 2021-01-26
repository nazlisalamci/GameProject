using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyuncuDogrulamaService:IOyuncuDogrulamaService
    {
        public bool OyuncuDogrula(IOyuncu oyuncu)
        {
            //oyuncunun değişkenleriyle e-devlet üzerindeki bilgilerin karşılaştırması.
            Console.WriteLine(oyuncu.Ad + " oyuncu onaylandı");
            return true;
        }
    }
}
