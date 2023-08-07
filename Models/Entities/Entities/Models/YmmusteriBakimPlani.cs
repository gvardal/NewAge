using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlani
{
    public int BakimPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public string? BakimPlaniKodu { get; set; }

    public short? SozlesmeId { get; set; }

    public int? MusteriKoduId { get; set; }

    public int? KontakId { get; set; }

    public int? BakimEkibiId { get; set; }

    public byte? ServisRotasiId { get; set; }

    public short? AracPlakasiId { get; set; }

    public string? DorsePlakasi { get; set; }

    public int? SoforId { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public string? PlanlananAracPlakasi { get; set; }

    public string? PlanlananDorsePlakasi { get; set; }

    public string? IrsSoforTcno { get; set; }

    public string? IrsSoforAdi { get; set; }

    public string? IrsSoforSoyadi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public short? GerceklesenBakimEkibiId { get; set; }

    public DateTime? GerceklesenYolaCikisTarihi { get; set; }

    public int? TasiyiciFirmaId { get; set; }

    public string? GonderiKodu { get; set; }

    public decimal? TasimaBedeli { get; set; }

    public byte? ParaBirimiId { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public string? SevkiyatFotografI { get; set; }

    public string? SevkiyatFotografIi { get; set; }

    public string? SevkiyatFotografIii { get; set; }

    public string? SevkiyatFotografIv { get; set; }

    public string? SevkiyatFotografV { get; set; }

    public string? DurumId { get; set; }

    public bool? Paketlendi { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public int? SiparisId { get; set; }

    public long? FaturaId { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public decimal? PaletAgirligi { get; set; }

    public decimal? ToplamDesi { get; set; }

    public DateTime? SevkiyatEmriTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public short? SevkiyatYontemiId { get; set; }

    public int? AmbarSevkiyatAdresiId { get; set; }

    public int? SevkSehirId { get; set; }

    public int? SevkIlceId { get; set; }

    public bool? KaliteOnay { get; set; }

    public int? KaliteOnaylayan { get; set; }

    public DateTime? KaliteOnayTarihi { get; set; }

    public bool? UretimOnay { get; set; }

    public int? UretimOnaylayan { get; set; }

    public DateTime? UretimOnayTarihi { get; set; }

    public bool? LojistikOnay { get; set; }

    public int? LojistikOnaylayan { get; set; }

    public DateTime? LojistikOnayTarihi { get; set; }

    public bool? FinansOnay { get; set; }

    public int? FinansOnaylayan { get; set; }

    public DateTime? FinansOnayTarihi { get; set; }

    public bool? GenelMudurOnay { get; set; }

    public int? GenelMudurOnaylayan { get; set; }

    public DateTime? GenelMudurOnayTarihi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual MiyambarBilgisi? AmbarSevkiyatAdresi { get; set; }

    public virtual Lyaraclar? AracPlakasi { get; set; }

    public virtual YmbakimEkibi? BakimEkibi { get; set; }

    public virtual PYmbakimDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual Ikcalisanlar? FinansOnaylayanNavigation { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual Ikcalisanlar? GenelMudurOnaylayanNavigation { get; set; }

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual Ikcalisanlar? KaliteOnaylayanNavigation { get; set; }

    public virtual Ikcalisanlar? Kontak { get; set; }

    public virtual Ikcalisanlar? LojistikOnaylayanNavigation { get; set; }

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }

    public virtual Miysahesaplar? MusteriKodu { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual PLyrotaBilgisi? ServisRotasi { get; set; }

    public virtual Pilceler? SevkIlce { get; set; }

    public virtual Psehirler? SevkSehir { get; set; }

    public virtual PsevkiyatYontemi? SevkiyatYontemi { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }

    public virtual Ikcalisanlar? Sofor { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Sysasozlesmeler? Sozlesme { get; set; }

    public virtual Miysahesaplar? TasiyiciFirma { get; set; }

    public virtual Ikcalisanlar? UretimOnaylayanNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniCanli> YmmusteriBakimPlaniCanlis { get; set; } = new List<YmmusteriBakimPlaniCanli>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
