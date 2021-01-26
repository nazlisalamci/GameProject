using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOyuncuServisi
    {
        void Add(IOyuncu oyuncu);
        void Update(IOyuncu oyuncu);
        void Delete(IOyuncu oyuncu);
    }
}
