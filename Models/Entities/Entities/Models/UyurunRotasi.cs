using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunRotasi
{
    public int UrunId { get; set; }

    public byte ZincirKodu { get; set; }

    public short AlternatifRotaId { get; set; }

    public bool? RotaGirdiKontrol { get; set; }

    public decimal? OrnekSayisi { get; set; }

    public short? IslemTuruId { get; set; }

    public int? KonumId { get; set; }

    public int? EkipmanId { get; set; }

    public int? MakinaId { get; set; }

    public string? UrunUretimTalimatlari { get; set; }

    public int? UretimTalimatiDokumaniId { get; set; }

    public string? KaliteKontrolTalimatlari { get; set; }

    public int? KontrolTalimatiId { get; set; }

    public bool? KontrolTipi { get; set; }

    public string? KontrolYontemi { get; set; }

    public string? MinDeger { get; set; }

    public string? MaksDeger { get; set; }

    public short? OrnekPlaniId { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public short? IsAkisSoruGrubuIdara { get; set; }

    public float? HazirlamaSuresi { get; set; }

    public float? IslemSuresi { get; set; }

    public float? StandartSure { get; set; }

    public float? Mesafe { get; set; }

    public short? OnSeriKontrolAdedi { get; set; }

    public decimal? LotBuyuklugu { get; set; }

    public decimal? VardiyaAdet { get; set; }

    public int? AdamSayisi { get; set; }

    public decimal? OperasyonAdedi { get; set; }

    public decimal? SetupSuresi { get; set; }

    public decimal? SetupAdedi { get; set; }

    public double? FireOrani { get; set; }

    public short? GozSayisi { get; set; }

    public byte[]? ResimDosyaAdi { get; set; }

    public string? SemaDosyaAdi { get; set; }

    public string? DiagramDosyaAdi { get; set; }

    public string? TeknikResimDosyaAdi { get; set; }

    public string? Notlar { get; set; }

    public int? CalisanId { get; set; }

    public int? TedarikciId { get; set; }

    public decimal? BirimFiyati { get; set; }

    public byte? ParaBirimiId { get; set; }

    public int? FasonUrunId { get; set; }

    public decimal? KullanilanMiktar { get; set; }

    public int? SecenId { get; set; }

    public bool? Secili { get; set; }

    public bool? Aktif { get; set; }

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

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Fdemirba? Ekipman { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uyurunler? FasonUrun { get; set; }

    public virtual UyisAkisSoruGruplari? IsAkisSoruGrubu { get; set; }

    public virtual UyisAkisSoruGruplari? IsAkisSoruGrubuIdaraNavigation { get; set; }

    public virtual UyislemTuru? IslemTuru { get; set; }

    public virtual Dybyevraklar? KontrolTalimati { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Fdemirba? Makina { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucus { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual Ikcalisanlar? Secen { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Miysahesaplar? Tedarikci { get; set; }

    public virtual Dybyevraklar? UretimTalimatiDokumani { get; set; }

    public virtual Uyurunler Urun { get; set; } = null!;

    public virtual ICollection<UyurunRotaGrubu> UyurunRotaGrubus { get; set; } = new List<UyurunRotaGrubu>();
}
