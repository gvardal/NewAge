using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdksbordroIzin
{
    public long BordroIzinId { get; set; }

    public int? CalisanId { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public string? GerekceTuru { get; set; }

    public string? IzinGerekcesi { get; set; }

    public decimal? IzinGunu { get; set; }

    public decimal? IzinSaat { get; set; }

    public byte? GerceklesenIzinGunu { get; set; }

    public decimal? GerceklesenIzinSaati { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? IptalEdildi { get; set; }

    public int? IptalEdenCalisanId { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public string? IptalAciklama { get; set; }

    public string? Aciklama { get; set; }

    public string? IzindekiAdresTelefon { get; set; }

    public byte? IzinTuruId { get; set; }

    public string? BordroIzinTuruId { get; set; }

    public DateTime? GoreveBaslamaTarihi { get; set; }

    public long? IzinTalepFormuBelgeId { get; set; }

    public long? DonusFormuBelgeId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual IkpdksbordroIzinTuru? BordroIzinTuru { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? IptalEdenCalisan { get; set; }

    public virtual PIkpdksizinTuru? IzinTuru { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
