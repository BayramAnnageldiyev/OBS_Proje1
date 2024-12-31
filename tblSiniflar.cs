using System;
using System.Collections.Generic;

namespace OBS_Proje
{
    public class tblSiniflar
    {
        public int Id { get; set; } 
        public string SinifAdi { get; set; }
        public int Kontenjan { get; set; } 

     
        public ICollection<Ogrenciler> Ogrenciler { get; set; }

        public tblSiniflar()
        {
            Ogrenciler = new List<Ogrenciler>();
        }
    }
}
