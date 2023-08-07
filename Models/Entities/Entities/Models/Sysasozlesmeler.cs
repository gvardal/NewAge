using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Sysasozlesmeler
{
    public short SozlesmeId { get; set; }

    public byte? SozlesmeTuruId { get; set; }

    public int? IhaleId { get; set; }

    public int? SasiparisId { get; set; }

    public int? SysiparisId { get; set; }

    public int? HesapId { get; set; }

    public int? YetkiliId { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? GecerlilikBaslangicTarihi { get; set; }

    public DateTime? GecerlilikBitisTarihi { get; set; }

    public decimal? SozlesmeBedeli { get; set; }

    public byte? ParaBirimiId { get; set; }

    public DateTime? SozlesmeTarihi { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

    public int? EvrakId { get; set; }

    public long? BelgeId { get; set; }

    public int? Onaylayan { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Dybyevraklar? Evrak { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual Saihaleler? Ihale { get; set; }

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesis { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual SateklifSipari? Sasiparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual PSysasozlesmeTuru? SozlesmeTuru { get; set; }

    public virtual Sysiparisler? Sysiparis { get; set; }

    public virtual Ikcalisanlar? Yetkili { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
