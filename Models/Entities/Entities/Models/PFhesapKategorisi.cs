using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFhesapKategorisi
{
    public byte HesapKategoriId { get; set; }

    public byte? HesapSinifi { get; set; }

    public string KategoriKoduAdi { get; set; } = null!;

    public string? KategoriAdi { get; set; }

    public string? Aciklama { get; set; }

    public string? KategoriSembolu { get; set; }

    public virtual ICollection<FyhesapPlani> FyhesapPlanis { get; set; } = new List<FyhesapPlani>();

    public virtual PFhesapSinifi? HesapSinifiNavigation { get; set; }
}
