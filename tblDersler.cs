using System;
using System.Collections.Generic;

namespace OBS_Proje
{
    public class tblDersler
    {
        public int Id { get; set; } 
        public string DersKodu { get; set; } 
        public string DersAdi { get; set; } 

        
        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; }

        public tblDersler()
        {
            OgrenciDersler = new List<tblOgrenciDers>();
        }
    }
}
