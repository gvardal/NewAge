using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KycatikToplamaKayitlari
{
    public int AtikToplamaId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? PartiNo { get; set; }

    public string? Tanimlama { get; set; }

    public string? ToplamaAlani { get; set; }

    public string? ToplamaEkibi { get; set; }

    /// <summary>
    /// True(Atik)-False(Bertaraf)
    /// </summary>
    public bool? BertarafAtik { get; set; }

    public string? BtasimaNo { get; set; }

    public DateTime? ByuklemeTarihi { get; set; }

    public string? Baciklama { get; set; }

    public int? BaliciAtikFirmaId { get; set; }

    public int? BtasiyiciAtikFirmaId { get; set; }

    public string? BsurucuAdiSoyadi { get; set; }

    public string? BplakaNo { get; set; }

    public string? BkamyonBilgisi { get; set; }

    public string? BraporNo { get; set; }

    public DateTime? BbertarafTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Miysahesaplar? BaliciAtikFirma { get; set; }

    public virtual Miysahesaplar? BtasiyiciAtikFirma { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayis { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
