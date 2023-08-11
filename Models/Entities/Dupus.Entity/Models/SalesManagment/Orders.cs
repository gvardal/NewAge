using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupus.Entity.Models.SalesManagment
{
    public class Orders
    {
        [Key]
        public int SiparisID { get; set; }
        public int FirmaID { get; set; }
        public int IsAlaniID { get; set; }
        public int SiparisKodu { get; set; }
        public int RevizyonNo { get; set; }
        public int SiparisTuru { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime TerminTarihi { get; set; }
        public DateTime PlanlananSevkiyatTarihi { get; set; }
        public int Durum { get; set; }
        public int MusteriKoduID { get; set; }
        public int Konu { get; set; }
        public int VadeKodu { get; set; }
        public int GecikmeCezasi { get; set; }
        public int DovizFaturasi { get; set; }
        public int RParaBirimi { get; set; }
        public double RKuru { get; set; }
        public int ParaBirimi { get; set; }
        public double KurOrani { get; set; }
        public double AraToplam { get; set; }
        public double DAraToplam { get; set; }
        public double IskontoOrani { get; set; }
        public double IskontoTutari { get; set; }
        public double DIskontoTutari { get; set; }
        public double VergiTutari { get; set; }
        public double DvergiTutari { get; set; }
        public double DTasima { get; set; }
        public double Yukleme { get; set; }
        public double DYukleme { get; set; }
        public double Toplam { get; set; }
        public double DToplam { get; set; }
        public double IskontoluToplam { get; set; }
        public double DIskontoluToplam { get; set; }
        public double Komisyon { get; set; }
        public int SevkiyatYontemi { get; set; }
        public int Gonderildi { get; set; }
        public int Onaylandi { get; set; }
        public int Onaylayan { get; set; }
        public DateTime OnayTarihi { get; set; }
        public int FinansOnayi { get; set; }
        public int SiparisAlanID { get; set; }
        public int EkleyenCalisanID { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int DuzenleyenCalisanID { get; set; }
        public DateTime DuzenlemeTarihi { get; set; }
    }

}
