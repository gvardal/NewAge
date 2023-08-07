using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Fykasalar
{
    public byte KasaId { get; set; }

    public byte? FirmaId { get; set; }

    public string? KasaKodu { get; set; }

    public string? KasaAdi { get; set; }

    public string KasaKoduAdi { get; set; } = null!;

    public int? SorumluId { get; set; }

    public decimal? Giren { get; set; }

    public decimal? Cikan { get; set; }

    public decimal? Bakiye { get; set; }

    public byte? ParaBirimiId { get; set; }

    public int? HesapPlaniId { get; set; }

    public bool? Varsayilan { get; set; }

    public bool? OtomatikYevmiyeKaydi { get; set; }

    public bool? Aktif { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleriAktarilacakKasas { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleriKasas { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual FyhesapPlani? HesapPlani { get; set; }

    public virtual ICollection<IkbordroAvan> IkbordroAvans { get; set; } = new List<IkbordroAvan>();

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? Sorumlu { get; set; }
}
