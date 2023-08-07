using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FygumrukBeyannamesi
{
    public string GumrukBeyannameId { get; set; } = null!;

    public bool? IhracatIthalat { get; set; }

    public int? MiysahesapId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? KutuAdedi { get; set; }

    public decimal? NetKg { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Kur { get; set; }

    public decimal? BeyannameBedeli { get; set; }

    public decimal? GumrukVergisiBedeli { get; set; }

    public decimal? Kdvbedeli { get; set; }

    public decimal? DamgaVergisiBedeli { get; set; }

    public decimal? OrdinoBedeli { get; set; }

    public decimal? ArdiyeBedeli { get; set; }

    public decimal? NavlunBedeli { get; set; }

    public decimal? MusavirlikBedeli { get; set; }

    public string? Aciklama { get; set; }

    public string? GumrukBeyannameKodu { get; set; }

    public decimal? KapanmaTarihiKuru { get; set; }

    public DateTime? BeyannameKapanmaTarihi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual Miysahesaplar? Miysahesap { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
