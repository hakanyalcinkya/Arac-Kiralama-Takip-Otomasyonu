using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaTakipOtomasyonu
{
    public class Araclar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public int Gunluk { get; set; }
        public int Haftalik { get; set; }
        public int Aylik { get; set; }
        public override string ToString()
        {
            return Marka + " " + Model;
        }
    }
}
