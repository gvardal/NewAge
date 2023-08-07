using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisEmri
{
    public long IsEmriId { get; set; }

    public byte FirmaId { get; set; }

    public int? MusteriKodu { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? KesimIsEmriId { get; set; }

    public decimal? KesimSuresi { get; set; }

    public decimal? KesilenMalzemeAgirligi { get; set; }

    public long? UstIsEmriId { get; set; }

    public string? IsEmriKodu { get; set; }

    public int UrunId { get; set; }

    public byte? IsEmriTuruId { get; set; }

    public string? UretimTuru { get; set; }

    public int? SiparisNo { get; set; }

    public byte? IsEmriDurumId { get; set; }

    public string? Oncelik { get; set; }

    public decimal UretimMiktari { get; set; }

    public decimal? StokRezervasyonMiktari { get; set; }

    public decimal? RezervasyonMiktari { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? GerceklesenBaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public decimal? GerceklesenSure { get; set; }

    public string? Aciklama { get; set; }

    public string? DurumNotu { get; set; }

    public string? UretimHatti { get; set; }

    public bool? IsEmriOnayi { get; set; }

    public int? Onaylayan { get; set; }

    public bool? Secili { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi Firma { get; set; } = null!;

    public virtual ICollection<FysatilanMalinMaliyetDetayi> FysatilanMalinMaliyetDetayis { get; set; } = new List<FysatilanMalinMaliyetDetayi>();

    public virtual ICollection<UyisEmri> InverseUstIsEmri { get; set; } = new List<UyisEmri>();

    public virtual PUyisEmriDurumu? IsEmriDurum { get; set; }

    public virtual PUyuretimPlaniTuru? IsEmriTuru { get; set; }

    public virtual UyuretimPlani? KesimIsEmri { get; set; }

    public virtual Miysahesaplar? MusteriKoduNavigation { get; set; }

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }

    public virtual Sysiparisler? SiparisNoNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Uyurunler Urun { get; set; } = null!;

    public virtual UyisEmri? UstIsEmri { get; set; }

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasis { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UysauretimPlaniSiparisDetayi> UysauretimPlaniSiparisDetayis { get; set; } = new List<UysauretimPlaniSiparisDetayi>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
