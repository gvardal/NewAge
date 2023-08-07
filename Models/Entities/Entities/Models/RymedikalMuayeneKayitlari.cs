using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RymedikalMuayeneKayitlari
{
    public int MedikalMuayeneId { get; set; }

    public string? ProtokolNo { get; set; }

    public int? CalisanId { get; set; }

    public DateTime? Tarih { get; set; }

    public short? MuayeneTipi { get; set; }

    public int? Hekim { get; set; }

    public string? Sikayetler { get; set; }

    public short? Tani { get; set; }

    public string? MuayeneNotlari { get; set; }

    public string? TedaviNotlari { get; set; }

    public short? MuayeneSonucu { get; set; }

    public bool? YuksekCalismaDurumu { get; set; }

    public bool? VardiyaCalismaDurumu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? HekimNavigation { get; set; }

    public virtual ICollection<RymedikalTahlil> RymedikalTahlils { get; set; } = new List<RymedikalTahlil>();

    public virtual ICollection<RyolcumDegerleri> RyolcumDegerleris { get; set; } = new List<RyolcumDegerleri>();

    public virtual ICollection<RyreceteKayitlari> RyreceteKayitlaris { get; set; } = new List<RyreceteKayitlari>();

    public virtual PRymedikalMuayeneTani? TaniNavigation { get; set; }
}
