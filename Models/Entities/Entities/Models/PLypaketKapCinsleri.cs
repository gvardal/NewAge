using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PLypaketKapCinsleri
{
    public string PaketKapId { get; set; } = null!;

    public string? PaketKapCinsi { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Agirligi { get; set; }

    public decimal? Hacmi { get; set; }

    public bool? Varsayilan { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
