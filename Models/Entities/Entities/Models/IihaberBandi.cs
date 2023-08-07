using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IihaberBandi
{
    public int HaberBandiId { get; set; }

    public byte? FirmaId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? HaberBasligi { get; set; }

    public string? HaberIcerigi { get; set; }

    public string? IlgiliBaglanti { get; set; }

    public string? IlgiliParametre { get; set; }

    public byte? HaberTuruId { get; set; }

    public DateTime? GecerlilikTarihi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public short? Begendim { get; set; }

    public short? Begenmedim { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public short? IlgiliSurecId { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual PIihaberBandiTuru? HaberTuru { get; set; }

    public virtual ICollection<IihaberBandiDagitimListesi> IihaberBandiDagitimListesis { get; set; } = new List<IihaberBandiDagitimListesi>();

    public virtual ICollection<IihaberBandiYorumlari> IihaberBandiYorumlaris { get; set; } = new List<IihaberBandiYorumlari>();

    public virtual Kysurecler? IlgiliSurec { get; set; }

    public virtual ICollection<Ikorganizasyonlar> Organizasyons { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Ikunvanlar> Unvans { get; set; } = new List<Ikunvanlar>();
}
