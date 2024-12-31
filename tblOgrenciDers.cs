using System;

namespace OBS_Proje
{
    public class tblOgrenciDers
    {
        public int OgrenciId { get; set; }
        public int DersId { get; set; }

       
        public Ogrenciler Ogrenci { get; set; }
        public tblDersler Ders { get; set; } 
    }
}
