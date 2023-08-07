using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisEmriArsivi
{
    public long IsEmriId { get; set; }

    public byte? FirmaId { get; set; }

    public int? MusteriKodu { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? UstIsEmriId { get; set; }

    public string? IsEmriKodu { get; set; }

    public int? UrunId { get; set; }

    public byte? IsEmriTuruId { get; set; }

    public string? UretimTuru { get; set; }

    public int? SiparisNo { get; set; }

    public byte? IsEmriDurumId { get; set; }

    public string? Oncelik { get; set; }

    public decimal? UretimMiktari { get; set; }

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

    public string? UretimHatti { get; set; }

    public bool? IsEmriOnayi { get; set; }

    public int? Onaylayan { get; set; }

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

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<UyisEmriArsivi> InverseUstIsEmri { get; set; } = new List<UyisEmriArsivi>();

    public virtual PUyisEmriDurumu? IsEmriDurum { get; set; }

    public virtual Miysahesaplar? MusteriKoduNavigation { get; set; }

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }

    public virtual Sysiparisler? SiparisNoNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UyuretimPlaniArsivi? UretimPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyisEmriArsivi? UstIsEmri { get; set; }

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsivis { get; set; } = new List<UyisEmriRotasiArsivi>();
}
