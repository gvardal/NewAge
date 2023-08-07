using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FykasaIslemleri
{
    public long KasaIslemId { get; set; }

    public byte? KasaId { get; set; }

    public int? FinansalDonemId { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? KurOrani { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public string? Aciklama { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public int? MiysahesapId { get; set; }

    public string? DosyaAdi { get; set; }

    public bool? Onay { get; set; }

    public byte? AktarilacakKasaId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Fykasalar? AktarilacakKasa { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual Fykasalar? Kasa { get; set; }

    public virtual Miysahesaplar? Miysahesap { get; set; }

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual FyyevmiyeDefteri? YevmiyeDefteri { get; set; }
}
