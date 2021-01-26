using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IOyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = 1;
            oyuncu1.Ad = "Nazlı";
            oyuncu1.Soyad = "Salamci";
            oyuncu1.TcNo = "34343434343";
            oyuncu1.DoğumYılı = new DateTime(2000, 07, 07);

            IOyuncuServisi oyuncuServisi = new OyuncuServisi();
            oyuncuServisi.Add(oyuncu1);
            oyuncuServisi.Delete(oyuncu1);
            oyuncuServisi.Update(oyuncu1);

            IOyuncuDogrulamaService dogrulamaService = new OyuncuDogrulamaService();
            dogrulamaService.OyuncuDogrula(oyuncu1);

            ISatis satis = new Satis();
            satis.OyunSatisi(oyuncu1);

            IKampanya kampanya = new Kampanya();
            kampanya.Add();
            kampanya.Delete();
            kampanya.Update();


         



        }
    }
}
