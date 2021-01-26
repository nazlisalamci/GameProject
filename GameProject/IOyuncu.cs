using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOyuncu
    {
       int Id { get; set; }
       string TcNo { get; set; }
       string Ad { get; set; }
       string Soyad { get; set; }
       DateTime DoğumYılı { get; set; }
    }
}
