using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyfaturaDetayiArttirimIndirim
{
    public int ArttirimiIndirimId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public bool? ArttirimIndirim { get; set; }

    public decimal? ArttirimiIndirimOrani { get; set; }

    public decimal? ArttirimiIndirimTutari { get; set; }

    public string? ArttirimiIndirimSebebi { get; set; }

    public virtual FyfaturaDetayi? FaturaDetayi { get; set; }
}
