using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RymalzemeBilgiGuvenlikFormlari
{
    public int Mbgfid { get; set; }

    public int? UrunId { get; set; }

    public short? Kategori { get; set; }

    public DateTime? Bgftarihi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? TradeChemicalSynonyms { get; set; }

    public string? Formula { get; set; }

    public string? Casno { get; set; }

    public string? Health { get; set; }

    public string? Flammability { get; set; }

    public string? Reactivity { get; set; }

    public string? Uretici { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PMbilgiGuvenlikFormKategori? KategoriNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
