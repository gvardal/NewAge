using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyvergiGrubuDetayi
{
    public short VergiGrubuDetayiId { get; set; }

    public byte? VergiGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public double? Oran { get; set; }

    public bool? Tevkifat { get; set; }

    public byte? AliciOrani { get; set; }

    public byte? SaticiOrani { get; set; }

    public int? SatinAlmaHesapKoduId { get; set; }

    public int? SatisHesapKoduId { get; set; }

    public virtual FyhesapPlani? SatinAlmaHesapKodu { get; set; }

    public virtual FyhesapPlani? SatisHesapKodu { get; set; }

    public virtual PFyvergiGrubu? VergiGrubu { get; set; }
}
