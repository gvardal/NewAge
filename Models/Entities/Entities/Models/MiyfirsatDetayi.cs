using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyfirsatDetayi
{
    public int FirsatDetayiId { get; set; }

    public int? FirsatId { get; set; }

    public int? UrunId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? BirimFiyat { get; set; }

    public byte? ParaBirimiId { get; set; }

    public int? OlcuBirimiId { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public decimal? Ambalaj { get; set; }

    public int? NakliyeKasaAdet { get; set; }

    public decimal? NakliyetKasaBedeli { get; set; }

    public decimal? Gümrükleme { get; set; }

    public byte? GumruklemeDosyaAdedi { get; set; }

    public decimal? DigerHizmet { get; set; }

    public int? DigerHizmetAdet { get; set; }

    public decimal? MalzemeFinansmani { get; set; }

    public decimal? KarMarji { get; set; }

    public decimal? IscilikKayip { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnalizis { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }
}
