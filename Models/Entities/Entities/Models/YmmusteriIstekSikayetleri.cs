using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriIstekSikayetleri
{
    public int MusteriIstekSikayetId { get; set; }

    public int? ProjeId { get; set; }

    public int? MusteriKontakAdiSoyadi { get; set; }

    public int? MusteriSirketAdi { get; set; }

    public int? UrunId { get; set; }

    public DateTime? BildirimTarihi { get; set; }

    public DateTime? TamamlanmaTarihi { get; set; }

    public bool? IstekSikayet { get; set; }

    public byte? IstekSikayetKategorisi { get; set; }

    public string? IstekSikayetKonusu { get; set; }

    public byte? IstekSikayetDurumuId { get; set; }

    public string? Aciklamasi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public decimal? HataliMiktar { get; set; }

    public byte? Yaklasim { get; set; }

    public byte? TeknikYeterlilik { get; set; }

    public byte? CozumSuresi { get; set; }

    public string? CozumSeviyesi { get; set; }

    public string? Degerlendirme { get; set; }

    public DateTime? SonTarih { get; set; }

    public int? SikayetiAlan { get; set; }

    public string? SikayetinDuyumSekli { get; set; }

    public int? Sorumlu { get; set; }

    public bool? DtdepartmanTalebi { get; set; }

    public int? DttalepEdenId { get; set; }

    public short? DtbirimId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikorganizasyonlar? Dtbirim { get; set; }

    public virtual Ikcalisanlar? DttalepEden { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual PYmistekSikayetDurumu? IstekSikayetDurumu { get; set; }

    public virtual PIstekSikayetKategorileri? IstekSikayetKategorisiNavigation { get; set; }

    public virtual ICollection<Kydof> Kydofs { get; set; } = new List<Kydof>();

    public virtual Ikcalisanlar? MusteriKontakAdiSoyadiNavigation { get; set; }

    public virtual Miysahesaplar? MusteriSirketAdiNavigation { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlaris { get; set; } = new List<PyprojeAdimlari>();

    public virtual Ikcalisanlar? SikayetiAlanNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumluNavigation { get; set; }

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriIstekSikayetleriDetayi> YmmusteriIstekSikayetleriDetayis { get; set; } = new List<YmmusteriIstekSikayetleriDetayi>();

    public virtual ICollection<YmuzaktanDestek> YmuzaktanDesteks { get; set; } = new List<YmuzaktanDestek>();
}
