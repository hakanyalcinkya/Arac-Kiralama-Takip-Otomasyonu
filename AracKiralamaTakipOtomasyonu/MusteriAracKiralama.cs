using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaTakipOtomasyonu
{
    public class MusteriAracKiralama
    {
        public int Id { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int MusteriId { get; set; }
        public string KiralamaSekli { get; set; }
        public int ToplamGun { get; set; }
        public int ToplamFiyat { get; set; }
        public int AracId { get; set; }
    }
}
