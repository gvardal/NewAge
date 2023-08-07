using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyuretimPlani
{
    public long UretimPlaniId { get; set; }

    public byte FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public string? UretimPlaniKodu { get; set; }

    public byte? RevizyonNo { get; set; }

    public byte? UretimPlaniTuruId { get; set; }

    public int? MiysahesapId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? SiparisId { get; set; }

    public int? UrunId { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public int? LotBuyuklugu { get; set; }

    public string? UretimTuru { get; set; }

    public string? Durum { get; set; }

    public byte? DurumId { get; set; }

    public string? Oncelik { get; set; }

    public DateTime PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitimTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitimTarihi { get; set; }

    public decimal? GerceklesenSure { get; set; }

    public string? Aciklama { get; set; }

    public string? AksesuarNotu { get; set; }

    public string? SiparisNotu { get; set; }

    public string? PlanlamaNotu { get; set; }

    public string? ProjeNotu { get; set; }

    public string? Sonuc { get; set; }

    public string? UretimHatti { get; set; }

    public decimal? UretimKatsayisi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? KesimIsEmriNo { get; set; }

    public int? KonumId { get; set; }

    public bool? Planlandi { get; set; }

    public int? PlanlayanId { get; set; }

    public decimal? KullanilabilirFireOrani { get; set; }

    public decimal? HurdaOrani { get; set; }

    public short? IslemTuruId { get; set; }

    public decimal? IslemSuresi { get; set; }

    public string? CamdosyaYolu { get; set; }

    public bool? UretimPlaniOnayi { get; set; }

    public int? Onaylayan { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public int? YevmiyeKaydiYapanId { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public virtual PUyisEmriDurumu? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi Firma { get; set; } = null!;

    public virtual ICollection<FysatilanMalinMaliyetDetayi> FysatilanMalinMaliyetDetayis { get; set; } = new List<FysatilanMalinMaliyetDetayi>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual UyislemTuru? IslemTuru { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Miysahesaplar? Miysahesap { get; set; }

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }

    public virtual Ikcalisanlar? Planlayan { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual Ggorevler? ProjeAdimi { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimiNavigation { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual PUyuretimPlaniTuru? UretimPlaniTuru { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UyisEmri> UyisEmriKesimIsEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyisEmri> UyisEmriUretimPlanis { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiKesimIsEmriNoNavigations { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiUretimPlanis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UysauretimPlaniSiparisDetayi> UysauretimPlaniSiparisDetayis { get; set; } = new List<UysauretimPlaniSiparisDetayi>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UyurunAgaciPlanlama> UyurunAgaciPlanlamas { get; set; } = new List<UyurunAgaciPlanlama>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyyerineKullanilacakUrunler> UyyerineKullanilacakUrunlers { get; set; } = new List<UyyerineKullanilacakUrunler>();

    public virtual FyyevmiyeDefteri? YevmiyeDefteri { get; set; }

    public virtual Ikcalisanlar? YevmiyeKaydiYapan { get; set; }

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
