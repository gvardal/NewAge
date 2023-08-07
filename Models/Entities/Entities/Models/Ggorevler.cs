using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ggorevler
{
    public int Id { get; set; }

    public int? PyprojeKoduId { get; set; }

    public byte? PygorevTuru { get; set; }

    public byte? PykrediPuani { get; set; }

    public byte? PyfaturalanmamaNedeniId { get; set; }

    public int? YmmusteriIstekSikayetId { get; set; }

    public int? ToplantiKatilimcisiId { get; set; }

    public int? GundemMaddesiId { get; set; }

    public int? HdonemHedefId { get; set; }

    public string? Hhedeflenen { get; set; }

    public string? Hgerceklesen { get; set; }

    public long? UretimPlaniId { get; set; }

    public int? Dofid { get; set; }

    public int? IsAkisVeriId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public byte? TanimliGorevId { get; set; }

    public int? UstGorevId { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public string? Oncelik { get; set; }

    public short? KisiOncul { get; set; }

    public byte? OlayTuru { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public long? Sure { get; set; }

    public int? PlanlananSure { get; set; }

    public bool? Hatirlatma { get; set; }

    public DateTime? HatirlatmaTarihi { get; set; }

    public bool? Yineleme { get; set; }

    public string? YinelemeTuru { get; set; }

    public byte? YinelemeSuresi { get; set; }

    public bool? ButunGun { get; set; }

    public bool? MusteriProjeYoneticisiBilgilendir { get; set; }

    public byte? Durumu { get; set; }

    public string? Tamamlanan { get; set; }

    public int? RandevuTuru { get; set; }

    public string? OlayYeri { get; set; }

    public string? RetSebebi { get; set; }

    public int? IlgiliKontak { get; set; }

    public int? IlgiliCalisan { get; set; }

    public int? MusteriKodu { get; set; }

    public int? Firsat { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? Uygulama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? TamamlanmaDurumu { get; set; }

    public int? Sorumlu { get; set; }

    public short? ProjeUnvaniId { get; set; }

    public short? ProjeTakimiId { get; set; }

    public string? Sonuc { get; set; }

    public double? Enlem { get; set; }

    public double? Boylam { get; set; }

    public decimal? Mesafe { get; set; }

    public short? LyaracId { get; set; }

    public byte? LyaracTipiId { get; set; }

    public string? Lyadres { get; set; }

    public int? LyadresIl { get; set; }

    public int? Lyilce { get; set; }

    public string? Lysemt { get; set; }

    public DateTime? LydegerlendirmeTarihi { get; set; }

    public int? Lydegerlendiren { get; set; }

    public bool? Lyonay { get; set; }

    public string? IiziyaretciAdi { get; set; }

    public string? IiziyaretciSoyadi { get; set; }

    public string? IiziyaretciFirmaAdi { get; set; }

    public DateTime? IiziyaretciDogumTarihi { get; set; }

    public string? IiziyaretciTcno { get; set; }

    public string? IiziyaretciGsm { get; set; }

    public string? IiziyaretciKartNo { get; set; }

    public string? IibilgisayarSeriNo { get; set; }

    public virtual Kydof? Dof { get; set; }

    public virtual PGgorevDurumu? DurumuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miyfirsatlar? FirsatNavigation { get; set; }

    public virtual ICollection<GgorevDetayi> GgorevDetayis { get; set; } = new List<GgorevDetayi>();

    public virtual ICollection<GgorevOnculleri> GgorevOnculleriOncekiGorevs { get; set; } = new List<GgorevOnculleri>();

    public virtual ICollection<GgorevOnculleri> GgorevOnculleriSonrakiGorevNavigations { get; set; } = new List<GgorevOnculleri>();

    public virtual ICollection<GgorevSorumlulari> GgorevSorumlularis { get; set; } = new List<GgorevSorumlulari>();

    public virtual IigundemMaddesi? GundemMaddesi { get; set; }

    public virtual ICollection<Iiiletisim> Iiiletisims { get; set; } = new List<Iiiletisim>();

    public virtual Ikcalisanlar? IlgiliCalisanNavigation { get; set; }

    public virtual Ikcalisanlar? IlgiliKontakNavigation { get; set; }

    public virtual ICollection<Ggorevler> InverseUstGorev { get; set; } = new List<Ggorevler>();

    public virtual Psehirler? LyadresIlNavigation { get; set; }

    public virtual Lyaraclar? Lyarac { get; set; }

    public virtual PLyaracTipi? LyaracTipi { get; set; }

    public virtual Ikcalisanlar? LydegerlendirenNavigation { get; set; }

    public virtual Pilceler? LyilceNavigation { get; set; }

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclaris { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual Miysahesaplar? MusteriKoduNavigation { get; set; }

    public virtual GolayTuru? OlayTuruNavigation { get; set; }

    public virtual PPyprojeTakimlari? ProjeTakimi { get; set; }

    public virtual PPyprojeGorevleri? ProjeUnvani { get; set; }

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual Pyprojeler? PyprojeKodu { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumluNavigation { get; set; }

    public virtual PGgorevTanimlar? TanimliGorev { get; set; }

    public virtual IitoplantiKatilimcisi? ToplantiKatilimcisi { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Ggorevler? UstGorev { get; set; }

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual YmmusteriIstekSikayetleri? YmmusteriIstekSikayet { get; set; }
}
