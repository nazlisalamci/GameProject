using System;
using System.Collections.Generic;
using System.Text;


namespace GameProject
{
    class OyuncuServisi : IOyuncuServisi
    {
       
        public void Add(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+" Added");
        }

        public void Delete(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Deleted");
        }

        public void Update(IOyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Updated");
        }
    }
}
