using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IiziyaretciKayit
{
    public int ZiyaretciKayitId { get; set; }

    public int? ZiyaretciHesapId { get; set; }

    public int? ZiyaretciKontakId { get; set; }

    public string? ZiyaretciFirmaAdi { get; set; }

    public string? ZiyaretciAdi { get; set; }

    public string? ZiyaretciSoyadi { get; set; }

    public string? ZiyaretciTcno { get; set; }

    public string? ZiyaretciGsm { get; set; }

    public DateTime? ZiyaretciDogumTarihi { get; set; }

    public string? ZiyaretciKartNo { get; set; }

    public int? ZiyaretEdilenId { get; set; }

    public string? ZiyaretKonusu { get; set; }

    public bool? Onay { get; set; }

    public string? Sonuc { get; set; }

    public DateTime? GelisTarihi { get; set; }

    public DateTime? CikisTarihi { get; set; }

    public string? BilgisayarSeriNo { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? ZiyaretEdilen { get; set; }

    public virtual Miysahesaplar? ZiyaretciHesap { get; set; }

    public virtual Ikcalisanlar? ZiyaretciKontak { get; set; }
}
