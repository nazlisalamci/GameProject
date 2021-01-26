using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Kampanya : IKampanya
    {
        public void Add()
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("kampanya silindi");
        }

        public void Update()
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
