using Microsoft.Identity.Client;

namespace OBS_Proje
{
    public class Ogrenciler
    {
        public int Id { get; set; } 
        public string Ad { get; set; }
        public string Soyad { get; set; } 
        public string Numara { get; set; } 
        public int SinifId { get; set; }

        // Navigation Properties
        public tblSiniflar Sinif { get; set; } 
      
        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; } 

        public Ogrenciler()
        {
            OgrenciDersler = new List<tblOgrenciDers>();
            
        }
    }
}
