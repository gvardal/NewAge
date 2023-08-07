using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdkssskgecmisi
{
    public int SskgecmisiId { get; set; }

    public int? CalisanId { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public byte? SubeId { get; set; }

    public int? ProjeId { get; set; }

    public short? MeslekGrubuId { get; set; }

    public string? SgkbelgeTuruId { get; set; }

    public short? SgkkanunId { get; set; }

    public bool? HazineYardimiKanunaTabi { get; set; }

    public bool? Beskesintisi { get; set; }

    public decimal? Prim { get; set; }

    public decimal? NetMaas { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? KumuleGv { get; set; }

    public string? EngelliDerecesi { get; set; }

    public bool? GelirVergisiHesapla { get; set; }

    public bool? DamgaVergisiHesapla { get; set; }

    public bool? Agihesapla { get; set; }

    public bool? AgineteDahil { get; set; }

    public bool? Cirak { get; set; }

    public bool? Emekli { get; set; }

    public bool? Yonetici { get; set; }

    public string? IstenCikisKoduId { get; set; }

    public byte? HakEdilenIzinGunu { get; set; }

    public decimal? HakEdilenIzinTutari { get; set; }

    public decimal? YillikKtbrut { get; set; }

    public decimal? KtdamgaVergisi { get; set; }

    public decimal? KidemTazminati { get; set; }

    public decimal? IhbarBrut { get; set; }

    public decimal? IhbarGv { get; set; }

    public decimal? IhbarDv { get; set; }

    public decimal? IhbarTazminati { get; set; }

    public decimal? NetOdenecekTutar { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();

    public virtual PIkistenCikisKodu? IstenCikisKodu { get; set; }

    public virtual PIkmeslekGruplari? MeslekGrubu { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PIkpdkssgkbelgeTurleri? SgkbelgeTuru { get; set; }

    public virtual PIksgkkanunlari? Sgkkanun { get; set; }

    public virtual PfirmaBilgisi? Sube { get; set; }
}
