using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{//TcNo, Ad, Soyad, DoğumYılı 
    class Oyuncu:IOyuncu
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DoğumYılı { get; set; }

    }
}
