using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyozellikTuru
{
    public short OzellikTuruId { get; set; }

    public short? OzellikGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public string? UzunAciklama { get; set; }

    public string AciklamaUzunAciklama { get; set; } = null!;

    public bool? RapordaGosterme { get; set; }

    public virtual ICollection<PUyozellikTuruSecenekleri> PUyozellikTuruSecenekleriOzellikTurus { get; set; } = new List<PUyozellikTuruSecenekleri>();

    public virtual ICollection<PUyozellikTuruSecenekleri> PUyozellikTuruSecenekleriSonrakiOzellikTurus { get; set; } = new List<PUyozellikTuruSecenekleri>();

    public virtual ICollection<UykategoriOzellikleri> UykategoriOzellikleris { get; set; } = new List<UykategoriOzellikleri>();

    public virtual ICollection<UyurunOzellikleri> UyurunOzellikleris { get; set; } = new List<UyurunOzellikleri>();
}
